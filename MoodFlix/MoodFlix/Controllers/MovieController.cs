using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MoodFlix.Model;
using MoodFlix.Model.Dto.MovieData;
using MoodFlix.Model.OpenAi;
using MoodFlix.Utilities;
using MoodFlix.Wrapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Collections.Generic;
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
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public MovieController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        #region GetMovies

        //POST: /api/movies/{total_movies}
        [AllowAnonymous]
        [HttpPost("{total_movies}")]
        public async Task<IActionResult> GetMovies(int total_movies)//, [FromBody] List<Emotion> emotions
        {
            //TODO: Use OpenAI API to get movie recommendations based on emotions and user preferences (platforms, genres and movies watched (history))
            // "movies" have a list of the movie titles
            var movies = await GetMoviesOpenAI(total_movies, new List<int>()); //TODO: Add the emotions

            //GetMoviesinfo
            var moviesInfo = await GetMovieInfo(movies);
            
            if(moviesInfo.Count == total_movies)
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
        private async Task<List<string>> GetMoviesOpenAI(int total_movies, List<int> emotionId)
        {
            string openAIKey = Utils.GetApiKey("OpenAI");
            string apiEndpoint = "https://api.openai.com/v1/chat/completions";
            /*
            int userId = 1;//GetLoggedUserId();

            //Get the movies watched by the user
            var moviesWatched = _context.History.Where(h => h.UserId == userId).Select(h => h.Movie.Title).ToList();
            List<MoviesWatched> mw = new List<MoviesWatched>();
            foreach (var movie in moviesWatched)
                mw.Add(new MoviesWatched() { Title = movie });
            
            List<Genre> userPreferredGenres = _context.UserGenre.Where(ug => ug.UserId == userId && ug.IsPreferred == true).Select(ug => ug.Genre).ToList();
            List<Genre> userNotPreferredGenres = _context.UserGenre.Where(ug => ug.UserId == userId && ug.IsPreferred == false).Select(ug => ug.Genre).ToList();

            //erase:
            emotionId.Add(24);
            emotionId.Add(20);
            emotionId.Add(6);

            //Get the emotions from the enum
            List<string> userEmotions = new List<string>();
            foreach (var emotion in emotionId)
                userEmotions.Add(((EnumEmotion)emotion).ToString());
            */
            //Prompt
            RequestOpenAi request = new RequestOpenAi() 
            { 
                Model = "gpt-3.5-turbo", //gpt-4o-mini        gpt-3.5-turbo
                Messages = new List<Message>()
                {
                    new Message() { Role = "user", Content = "Recommend me a movie" }
                },
                MaxTokens = 30,
                Temperature = 0.6f
            };
            
            //Create the request
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {openAIKey}");
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", openAIKey);

            var json = System.Text.Json.JsonSerializer.Serialize(request);
            var body = new StringContent(json, Encoding.UTF8, "application/json");
            
            //Send the request
            var response = await client.PostAsync(apiEndpoint, body);

            
            if (response.IsSuccessStatusCode)
            {
                //Get the response
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);
                /*
                 RESPUESTA
                 {
  "id": "chatcmpl-AYgZZFZL2TyEU3Nuoegb4ZzZqaoZ7",
  "object": "chat.completion",
  "created": 1732830165,
  "model": "gpt-3.5-turbo-0125",
  "choices": [
    {
      "index": 0,
      "message": {
        "role": "assistant",
        "content": "I recommend the movie \"The Shawshank Redemption.\" It is a classic drama film that tells the story of a man who is wrongly imprisoned for a",
        "refusal": null
      },
      "logprobs": null,
      "finish_reason": "length"
    }
  ],
  "usage": {
    "prompt_tokens": 11,
    "completion_tokens": 30,
    "total_tokens": 41,
    "prompt_tokens_details": {
      "cached_tokens": 0,
      "audio_tokens": 0
    },
    "completion_tokens_details": {
      "reasoning_tokens": 0,
      "audio_tokens": 0,
      "accepted_prediction_tokens": 0,
      "rejected_prediction_tokens": 0
    }
  },
  "system_fingerprint": null
}
                */
            }
            else
            {
                //Error
                Console.WriteLine("Error:" + response.StatusCode);
            }
            
            //response: only the movie names
            return new List<string>(){"The godfather"};
        }

        /// <summary>
        /// Search the movies info in StreamingAvailability API
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private async Task<List<MovieDataDTO>> GetMovieInfo(List<string> moviesTitles)
        {
        //Get the platforms from "
        //https://streaming-availability.p.rapidapi.com/shows/search/title?country=es&title=inception&series_granularity=show&show_type=movie&output_language=en"
            
            //var userId = GetLoggedUserId();
            var userId = 1;

            //Get the user country code
            //string userCountry = _context.User.Where(u => u.UserId == userId).Select(u => u.Country.CountryName).FirstOrDefault();

            //Create the request
            var apiKey = Utils.GetApiKey("StreamingAvailability");
            string userCountry = "es";

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
                    movieFound = CheckMoviesPlatform(userId, movieData);

                    if (movieFound)
                    {
                        //Add the movie info to the list
                        moviesData.Add(movieData);
                    }
                    else
                    {
                        //Movie not found, add a null object to the list
                    }
                }                
            }

            return moviesData;
        }
        
        /// <summary>
        /// Check if the movies are in the user platforms
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private bool CheckMoviesPlatform(int userId, MovieDataDTO movie)
        {
            //Get the user platforms
            var userPlatformsId = _context.UserPlatform.Where(up => up.UserId == userId).Select(up => up.PlatformId).ToList();
            var userPlatforms = _context.Platform.Where(p => userPlatformsId.Contains(p.PlatformId)).ToList();

            var moviePlatforms = movie.StreamingOptions.ServiceOptions.Select(s => s.ServiceName).ToList();

            if (userPlatforms.Any(p => moviePlatforms.Contains(p.PlatformName)))
                return true;

            return false;
        }


        private MovieDataDTO GetMovieInfoFromJArray(JArray moviesResponse, string userCountry)
        {
            //Get the first movie
            JObject movie = (JObject)moviesResponse[0];

            //Get the movie info

            int id = movie["id"]?.Value<int>() ?? 0;//Movie info!
            string title = movie["title"]?.ToString();//Movie info!
            string overview = movie["overview"]?.ToString();//Movie info!

            //Get the genres
            JToken genresJToken = movie["genres"];
            List<string> genresList = new List<string>(); //Movie info!
            foreach (var genreJToken in genresJToken)
            {
                genresList.Add(genreJToken["name"].ToString());
            }

            //Get the directors
            JToken directorsJToken = movie["directors"];
            List<string> directors = new List<string>();//Movie info!
            foreach (var directorJToken in directorsJToken)
            {
                directors.Add(directorJToken.ToString());
            }

            //Get the runtime
            int runtime = movie["runtime"]?.Value<int>() ?? 0;

            //Get the image
            var imageSet = movie["imageSet"];
            var verticalPosterInfo = imageSet["verticalPoster"];
            VerticalPoster verticalPoster = new VerticalPoster() //Movie info!
            {
                W240 = verticalPosterInfo["w240"].ToString(),
                W360 = verticalPosterInfo["w360"].ToString(),
                W480 = verticalPosterInfo["w480"].ToString(),
            };

            //Get the streaming options
            var streamingOptions = movie["streamingOptions"];
            var countryStremingOptions = streamingOptions[userCountry];
            List<StreamingService> streamingServices = new List<StreamingService>();//Movie info!
            foreach (var streamingService in countryStremingOptions)
            {
                //foreach streaming service need to get the service name and the url
                streamingServices.Add(new StreamingService()
                {
                    ServiceName = streamingService["service"]["name"]?.ToString(),//this get the service name ???
                    Link = streamingService["link"]?.ToString(),
                    ImageSet = new ServiceImageSet()
                    {
                        lightThemeImage = streamingService["service"]["imageSet"]["lightThemeImage"].ToString(),
                        darkThemeImage = streamingService["service"]["imageSet"]["darkThemeImage"].ToString(),
                        whiteImage = streamingService["service"]["imageSet"]["whiteImage"].ToString()
                    }
                });
            }

            MovieDataDTO movieData = new MovieDataDTO()
            {
                Id = id,
                Title = title,
                Overview = overview,
                Genres = genresList,
                Directors = directors,
                Runtime = runtime,
                ImageSet = new ImageSet()
                {
                    VerticalPoster = verticalPoster
                },
                StreamingOptions = new StreamingOptions()
                {
                    ServiceOptions = streamingServices
                }
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
