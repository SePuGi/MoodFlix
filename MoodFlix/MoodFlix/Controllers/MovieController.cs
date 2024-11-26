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
        public async Task<IActionResult> GetMovies(int total_movies)//, [FromBody] List<Emotion> emotions
        {
            //TODO: Use OpenAI API to get movie recommendations based on emotions and user preferences (platforms, genres and movies watched (history))
            GetMoviesOpenAI(total_movies);

            return NotFound();
        }

        #endregion

        #region Utils

        private async Task<string> GetMoviesOpenAI(int total_movies)
        {
            string openAIKey = Utils.GetApiKey("OpenAI");
            string apiEndpoint = "https://api.openai.com/v1/completions";

            string prompt = "";
            
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
            return "";
        }

        //Check if the movie is in the platform
        #endregion
    }
}
