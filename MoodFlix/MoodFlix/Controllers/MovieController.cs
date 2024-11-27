using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MoodFlix.Model;
using MoodFlix.Utilities;
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
        public async Task<IActionResult> GetMovies(int total_movies, [FromBody] List<Emotion> emotions)//, [FromBody] List<Emotion> emotions
        {
            //TODO: Use OpenAI API to get movie recommendations based on emotions and user preferences (platforms, genres and movies watched (history))
            // "movies" have a list of the movie titles
            var movies = await GetMoviesOpenAI(total_movies, new List<int>()); //TODO: Add the emotions

            //GetMoviesinfo
            var moviesInfo = GetMovieInfo(movies);
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
            
            //response: only the movie names
            return new List<string>(){"Pelicula 1","Pelicula 2","Pelicula 3","Pelicula 4","Pelicula 5" };
        }

        /// <summary>
        /// Search the movies info in StreamingAvailability API
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private List<Movie> GetMovieInfo(List<string> movies)
        {
        //Get the platforms from "
        https://streaming-availability.p.rapidapi.com/shows/search/title?country=es&title=inception&series_granularity=show&show_type=movie&output_language=en"

            //Create the request
            var apiKey = Utils.GetApiKey("StreamingAvailability");
            //string userCountry = GetUserCountryCode

            foreach(string movie in movies) 
            {
                movie.Replace(" ", "+");

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"\r\nhttps://streaming-availability.p.rapidapi.com/shows/search/title?country=es&title={movie}&series_granularity=show&show_type=movie&output_language=en"),
                    Headers =
                    {
                        { "x-rapidapi-key", apiKey },
                        { "x-rapidapi-host", "streaming-availability.p.rapidapi.com" },
                    },
                };
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
        #endregion
    }
}
