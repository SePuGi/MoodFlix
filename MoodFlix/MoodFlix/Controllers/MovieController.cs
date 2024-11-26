using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            
            string openAIKey = Utils.GetApiKey("OpenAI");

            return NotFound(openAIKey);
        }

        #endregion
    }
}
