using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MoodFlix.Model;
using MoodFlix.Model.Dto;
using MoodFlix.Model.Dto.MovieData;
using MoodFlix.Model.OpenAi;
using MoodFlix.Utilities;
using MoodFlix.Wrapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using Message = MoodFlix.Model.OpenAi.Message;

namespace MoodFlix.Controllers
{
    [Authorize]//This will make the controller only accessible to authenticated users (JWT)
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly string GPTModel = "gpt-4o-mini";//gpt-4o-mini       gpt-3.5-turbo

        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public MovieController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        #region GetMovies

        /// <summary>
        /// Get X movies based on user preferences
        /// </summary>
        /// <param name="total_movies"></param>
        /// <param name="emotionsId"></param>
        /// <returns></returns>
        //POST: /api/movies/{total_movies}
        [HttpPost("GetMoviesWithPreferences/{total_movies}")]
        public async Task<IActionResult> GetMoviesWithPreferences(int total_movies, [FromBody] GetMoviesDTO? userPreferences)
        {
            //int userId = 1;
            int userId = GetLoggedUserId();

            if (userId == -1)
                return Unauthorized("User not found");

            // "movies" have a list of the movie titles
            var movies = await GetMoviesOpenAI(userId, total_movies, userPreferences);

            if (movies.Count == 0)
                return NotFound("No movies found");

            //GetMoviesinfo
            var moviesInfo = await GetMovieInfo(userId, movies);

            if (moviesInfo.Count == total_movies)
                return Ok(moviesInfo);

            //Get more movies?
            return Ok(moviesInfo);
        }

        /// <summary>
        /// Get X movies based on user preferences and emotions
        /// </summary>
        /// <param name="total_movies"></param>
        /// <param name="emotionsId"></param>
        /// <returns></returns>
        //POST: /api/movies/{total_movies}
        [HttpPatch("GetMoviesWithEmotions/{total_movies}")]
        public async Task<IActionResult> GetMoviesWithEmotions(int total_movies, [FromBody] GetMoviesDTO userPreferences)
        {
            int userId = GetLoggedUserId();

            if(userId == -1)
                return Unauthorized("User not found");

            // "movies" have a list of the movie titles
            var movies = await GetMoviesOpenAI(userId,total_movies, userPreferences);

            if (movies.Count == 0)
                return NotFound("No movies found");

            //GetMoviesinfo
            var moviesInfo = await GetMovieInfo(userId, movies);

            if (moviesInfo.Count == total_movies)
                return Ok(moviesInfo);

            //Get more movies?
            return Ok(moviesInfo);
        }

        #endregion

        #region Utils

        /// <summary>
        /// This method will get the movie recommendations from OpenAI API
        /// Return a list of movie titles
        /// </summary>
        /// <param name="total_movies"></param>
        /// <param name="emotionId"></param>
        /// <returns></returns>
        private async Task<List<string>> GetMoviesOpenAI(int userId, int total_movies, GetMoviesDTO userPreferences)
        {
            string openAIKey = Utils.GetApiKey("OpenAI");
            string apiEndpoint = "https://api.openai.com/v1/chat/completions";
            
            List<Message> prompt= new List<Message>();
            prompt = await CreatePrompt(userId, total_movies, userPreferences);

            //Prompt
            RequestOpenAi request = new RequestOpenAi() 
            { 
                Model = GPTModel, 
                Messages = prompt,
                MaxTokens = 200,
                Temperature = 2f,
                TopP = 0.9f
            };

            foreach (var message in prompt)
            {
               Console.WriteLine(message.Content); ;
            }

            //Create the request
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {openAIKey}");

            var json = System.Text.Json.JsonSerializer.Serialize(request);
            var body = new StringContent(json, Encoding.UTF8, "application/json");
            
            //Send the request
            var response = await client.PostAsync(apiEndpoint, body);

            List<string> moviesResponse = new List<string>();

            if (response.IsSuccessStatusCode)
            {
                //Get the response
                var responseString = await response.Content.ReadAsStringAsync();

                //Get the content from the response using RequestOpenAi class
                var responseObj = JsonConvert.DeserializeObject<ResponseOpenAi>(responseString);

                //Get the movies from the response (responseObj.Choices[0].Message.Content) <- this is a json string with the movies titles
                var movies = JsonConvert.DeserializeObject<MovieContent>(responseObj.Choices[0].Message.Content);

                moviesResponse = movies.Movie;
            }

            //response: only the movie names
            return moviesResponse;
        }

        private async Task<List<Message>> CreatePrompt(int userId, int totalMovies, GetMoviesDTO userPreferences)
        {
            List<Message> message = new List<Message>();

            //Add conversation context (you are a movie expert...)
            if(userPreferences.EmotionsId != null)
                message.Add(new Message() { Role = "system", Content = "You are an expert movie recommender. Your job is to suggest movies based on the streaming platforms the user has, the user's genre preferences, avoiding the genres they don't want, and considering their current emotions to improve their mood. You must also take into account the movies they have already watched to avoid recommending them again. The recommendations should be useful and in JSON format." });
            else
                message.Add(new Message() { Role = "system", Content = "You are an expert movie recommender. Your job is to suggest random movies based on the streaming platforms the user has, avoiding the genres they don't want. You must also take into account the movies they have already watched to avoid recommending them again. The recommendations should be in JSON format." });

            //Get the movies watched by the user
            var moviesWatched = _context.History.Where(h => h.UserId == userId).Select(h => h.Movie.Title).ToList();
            List<MoviesWatched> mw = new List<MoviesWatched>();
            foreach (var movie in moviesWatched)
                mw.Add(new MoviesWatched() { Title = movie });

            //Get the user platforms preferences
            var platforms = _context.UserPlatform.Where(up => up.UserId == userId).Select(up => up.Platform.PlatformName).ToList();

            //Get the user genre preferences
            List<Genre> userNotPreferredGenres = _context.UserGenre.Where(ug => ug.UserId == userId && ug.IsPreferred == false).Select(ug => ug.Genre).ToList();

            //Add the platforms if there are any, if not, do no add this message
            if (platforms.Count != 0)
                message.Add(new Message() { Role = "system", Content = $"I have access to these platforms: {string.Join(",", platforms)}" });

            //Add the movies watched if there are any, if not, do no add this message
            if (mw.Count != 0)
                message.Add(new Message() { Role = "system", Content = $"I have seen this movies (don't use it as a reference for the suggest): {string.Join(",", moviesWatched)}" });

            //Add the movies suggested if there are any, if not, do no add this message
            if (userPreferences.MoviesSuggested.Count != 0)
                message.Add(new Message() { Role = "system", Content = $"Don't recommend any of this: {string.Join(",", userPreferences.MoviesSuggested)}" });

            //Add the emotion the user want to feel watching the movie
            if (userPreferences.EmotionId != null)
            {
                var emotion = await _context.Emotion.Where(e => e.EmotionId == userPreferences.EmotionId).Select(e => e.EmotionName).FirstOrDefaultAsync();
                message.Add(new Message() { Role = "system", Content = $"I want to feel {emotion} watching this movie." });
            }

            //Add the user not preferred genres if there are any, if not, do no add this message
            if (userNotPreferredGenres.Count != 0)
                message.Add(new Message() { Role = "system", Content = $"I don't want movies with the genres: {string.Join(",", userNotPreferredGenres)}" });

            //Add the age of the user
            var birthDate = _context.User.Where(u => u.UserId == userId).Select(u => u.BirthDate).FirstOrDefault();
            var age = DateTime.Now.Year - birthDate.Year;

            message.Add(new Message() { Role = "system", Content = $"I am {age} years old" });

            if (userPreferences.EmotionsId != null)
            {
                //Get the emotions from the enum
                var emotions = _context.Emotion.Where(e => userPreferences.EmotionsId.Contains(e.EmotionId)).Select(e => e.EmotionName).ToList();

                //Add emotions context if there are any
                message.Add(new Message() { Role = "system", Content = $"This emotions can resume my feelings: {string.Join(",", emotions)}" });
            }
            //else
            //Only get the movies with moviesWatched, genre and platform preferences

            //Generate json with the total movies
            if(GPTModel.Contains("4o-mini"))    //gpt-4o-mini       gpt-3.5-turbo
                message.Add(new Message() { Role = "user", Content = $"Generate a list of {totalMovies} movies that meet these criteria. The output format should be JSON with the following structure: {{ \"movies\": [\"Movie Name 1\", \"Movie Name 2\", ...] }}. Don't use backticks just the JSON format" });
            else
                message.Add(new Message() { Role = "user", Content = $"Generate a list of {totalMovies} movies that meet these criteria. The output format should be JSON with the following structure: {{ \"movies\": [\"Movie Name 1\", \"Movie Name 2\", ...] }}." });
            
            return message;
        }

        /// <summary>
        /// Search the movies info in StreamingAvailability API
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private async Task<List<MovieDataDTO>> GetMovieInfo(int userId, List<string> moviesTitles)
        {
            //Get the platforms from "
            //https://streaming-availability.p.rapidapi.com/shows/search/title?country=es&title=inception&series_granularity=show&show_type=movie&output_language=en"
            
            //Get the user country code
            string userCountry = await _context.User.Where(u => u.UserId == userId).Select(u => u.Country.CountryCode).FirstOrDefaultAsync();

            //Create the request
            var apiKey = Utils.GetApiKey("StreamingAvailability");

            bool movieFound = false;

            List<MovieDataDTO> moviesData = new List<MovieDataDTO>();

            foreach (string movieTitle in moviesTitles)
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"\r\nhttps://streaming-availability.p.rapidapi.com/shows/search/title?country={userCountry}&title={movieTitle.Replace(" ", "+")}&series_granularity=show&show_type=movie&output_language=en"),
                    Headers =
                    {
                        { "x-rapidapi-key", apiKey },
                        { "x-rapidapi-host", "streaming-availability.p.rapidapi.com" },
                    },
                };

                //Send the request
                var response = await new HttpClient().SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    //Get the response
                    var responseString = await response.Content.ReadAsStringAsync();

                    //this need to be a JArray, can't do a DTO
                    JArray moviesResponse = JArray.Parse(responseString);

                    MovieDataDTO movieData = GetMovieInfoFromJArray(moviesResponse, userCountry);

                    //Check if the movie is in the platform
                    if(movieData.StreamingOptions.ServiceOptions.Count != 0)
                        movieFound = await CheckMoviesPlatform(userId, movieData);

                    if (movieFound)     //Add the movie info to the list
                        moviesData.Add(movieData);
                    
                    else                //Movie not found
                        return new List<MovieDataDTO>();
                    
                }                
            }

            return moviesData;
        }
        
        /// <summary>
        /// Check if the movies are in the user platforms
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private async Task<bool> CheckMoviesPlatform(int userId, MovieDataDTO movie)
        {
            //Get the user platforms
            var userPlatformsId = await _context.UserPlatform.Where(up => up.UserId == userId).Select(up => up.PlatformId).ToListAsync();
            var userPlatforms = await _context.Platform.Where(p => userPlatformsId.Contains(p.PlatformId)).ToListAsync();

            if(userPlatforms.Count == 0)// if the user has no platforms, return all the movies
                return true;

            var moviePlatforms = movie.StreamingOptions.ServiceOptions.Select(s => s.ServiceName).ToList();

            if (userPlatforms.Any(p => moviePlatforms.Contains(p.PlatformName)))
                return true;

            return false;
        }

        private MovieDataDTO GetMovieInfoFromJArray(JArray moviesResponse, string userCountry)
        {
            //Get the first movie
            JObject movie = (JObject)moviesResponse[0];

            //Deserialize part of the movie to a DTO
            MovieDataDTO movieData = movie.ToObject<MovieDataDTO>();

            //Get the streaming options from the object (streamingOptions atributte name is the countryCode, can't do a dto with a dynamic name)
            var streamingOptions = movie["streamingOptions"];

            //Check if the movie has streaming options
            if (streamingOptions == null)
                return movieData;

            var countryStremingOptions = streamingOptions[userCountry.ToLower()];
            List<StreamingService> streamingServices = new List<StreamingService>();//Movie info!
            foreach (var streamingService in countryStremingOptions)
            {
                //foreach streaming service need to get the service name and the url
                streamingServices.Add(new StreamingService()
                {
                    ServiceName = streamingService["service"]["name"]?.ToString(),//this get the service name
                    AccesType = streamingService["type"]?.ToString(),
                    Link = streamingService["link"]?.ToString(),
                    ImageSet = new ServiceImageSet()
                    {
                        lightThemeImage = streamingService["service"]["imageSet"]["lightThemeImage"].ToString(),
                        darkThemeImage = streamingService["service"]["imageSet"]["darkThemeImage"].ToString(),
                        whiteImage = streamingService["service"]["imageSet"]["whiteImage"].ToString()
                    }
                });
            }

            movieData.StreamingOptions = new StreamingOptions()
            {
                ServiceOptions = streamingServices
            };
            return movieData;
        }

        private int GetLoggedUserId()
        {
            int idUser = 0;

            try
            {
                idUser = int.Parse(User.FindFirst("UserId").Value);
            }
            catch (Exception e)
            {
                return -1;
            }

            return idUser;
        }

        #endregion
    }
}
