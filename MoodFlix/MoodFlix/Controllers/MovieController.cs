using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MoodFlix.Model;
using MoodFlix.Model.Dto.MovieData;
using MoodFlix.Utilities;
using MoodFlix.Wrapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Collections.Generic;
using System.Xml.Linq;

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
            /*
            //if the moviesInfo is correct return the movies
            if (CheckMoviesPlatform(moviesInfo))
            {

            }
            else
                return NotFound();*/
            
            //return the movies info

            return NotFound();
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
            string apiEndpoint = "https://api.openai.com/v1/completions";

            string prompt = "";

            //TODO: Create the prompt to get the movie recommendations with the user preferences and emotions
            //Request body
            /*
            var requestData = new
            {
                model = "gpt-4o-mini", //gpt-3.5-turbo
                messages = new[]
                    {
                        new { role = "system", content = "Movie context" },
                        new { role = "system", content = "Movies watched context" },
                        new { role = "system", content = "Genre context" },
                        new { role = "system", content = "Emotion context" },
                        new { role = "system", content = "Output context (show 1-5 movies in format json like { \"movies\" : [string movieNames] }" },
                        new { role = "user", content = $"Genera una lista de {total_movies} películas de ciencia ficción populares." }
                    },
                prompt = prompt,
                max_Tokens = 100,
                temperature = 0.6
            };
            */
            //response: only the movie names
            return new List<string>(){"The godfather"};
        }

        /// <summary>
        /// Search the movies info in StreamingAvailability API
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private async Task<List<MovieDataDTO>> GetMovieInfo(List<string> movies)
        {
        //Get the platforms from "
        //https://streaming-availability.p.rapidapi.com/shows/search/title?country=es&title=inception&series_granularity=show&show_type=movie&output_language=en"
            
            //var userId = GetLoggedUserId();

            //Get the user country code
            //string userCountry = _context.User.Where(u => u.UserId == userId).Select(u => u.Country.CountryName).FirstOrDefault();

            //Create the request
            var apiKey = Utils.GetApiKey("StreamingAvailability");
            string userCountry = "es";

            bool movieFound = false;

            List<MovieDataDTO> moviesInfo = new List<MovieDataDTO>();

            foreach (string movieTitle in movies)
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

                //Get the first movie that have the same title
                MovieDataDTO movieInfo = new MovieDataDTO();

                //Send the request
                var response = await new HttpClient().SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    //Get the response
                    var responseString = await response.Content.ReadAsStringAsync();

                    //this need to be a JArray, can't do a DTO
                    JArray moviesResponse = JArray.Parse(responseString);

                    foreach (var movie in moviesResponse)
                    {
                        var streamingOptions = movie["streamingOptions"];
                        if (streamingOptions != null)
                        {
                            var usServices = streamingOptions[userCountry];//-> this is a JArray (in string) need to parse to a DTO
                        }
                    }
                }

                if (movieFound)
                {
                    //Add the movie info to the list

                    //moviesInfo.Add(movieInfo);
                }
                else 
                {
                    //Movie not found, add a null object to the list
                }
            }

            return null;
        }
        
        /// <summary>
        /// Check if the movies are in the user platforms
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private bool CheckMoviesPlatform(List<string> movies)
        {
            return true;
        }
        //Check if the movie is in the platform


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
