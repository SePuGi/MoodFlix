using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using MoodFlix.Model;
using MoodFlix.Model.Dto;
using MoodFlix.Model.Questionary;
using MoodFlix.Utilities;
using MoodFlix.Wrapper;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MoodFlix.Controllers
{
    //[Authorize]//This will make the controller only accessible to authenticated users (JWT)
    [Route("api/questionary")]
    [ApiController]
    public class QuestionaryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly Questionary _questionary;

        public QuestionaryController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _questionary = QuestionaryInitializer.CreateQuestionary();
        }

        #region GetQuestionary

        /// <summary>
        /// Retrieve the questionary with its questions and options.
        /// </summary>
        /// <returns>A list of questions with their available answers.</returns>
        [HttpGet]
        public IActionResult GetQuestionary()
        {
            var response = _questionary.Questions.Select(q => new
            {
                question = q.Text,
                answers = q.Options.Select(o => new
                {
                    key = o.Key,
                    text = o.Text,
                })
                .ToList()
            }).ToList();

            return Ok(response);
        }

        #endregion

        #region SubmitQuestionary

        /// <summary>
        /// Process the responses of the questionary and calculate the emotion scores.
        /// </summary>
        /// <param name="responses">A list of user responses to the questionary.</param>
        /// <param name="registerId">An optional register ID for storing the history.</param>
        /// <returns>The top three emotions based on the user's responses.</returns>
        [HttpPost]
        public IActionResult SubmitQuestionary([FromBody] List<QuestionaryResponseDTO> responses, [FromQuery] int registerId)
        {
            if (responses == null || responses.Count == 0)
            {
                return BadRequest("The questionnaire responses are invalid or empty.");
            }

            // Dictionary to accumulate emotion scores
            var emotionScores = new Dictionary<int, int>();

            foreach (var response in responses)
            {
                // Find the corresponding question
                var question = _questionary.Questions.FirstOrDefault(q => q.Text == response.Question);
                if (question == null)
                {
                    return NotFound($"Question '{response.Question}' not found.");
                }

                // Find the user's selected answer
                var selectedOption = question.Options.FirstOrDefault(o => o.Key == response.Answer);
                if (selectedOption == null)
                {
                    return NotFound($"Answer '{response.Answer}' for question '{response.Question}' not found.");
                }

                // Add scores for each associated emotion
                AddEmotionScore(emotionScores, (int)selectedOption.PrimaryEmotion, 4); // Primary: 4 points
                AddEmotionScore(emotionScores, (int)selectedOption.SecondaryEmotion, 2); // Secondary: 2 points
                AddEmotionScore(emotionScores, (int)selectedOption.TertiaryEmotion, 1); // Tertiary: 1 point
            }

            // Sort emotions by score and select the top three
            var sortedEmotions = emotionScores
                .OrderByDescending(e => e.Value)
                .Take(3)
                .Select(e => new EmotionDTO
                {
                    Id = e.Key,
                    Name = ((EnumEmotion)e.Key).ToString(),
                    Score = e.Value
                })
                .ToList();

            // Save emotion scores to the database (optional, commented out)
            /*
            foreach (var emotion in sortedEmotions)
            {
                var historyEmotion = new HistoryEmotion
                {
                    RegisterId = registerId,
                    EmotionId = emotion.Id,
                    Score = emotion.Score
                };
                _context.HistoryEmotion.Add(historyEmotion);
            }
            _context.SaveChanges();
            */

            // Return the calculated emotions
            return Ok(sortedEmotions);
        }

        #endregion

        #region Utils

        /// <summary>
        /// Increment the score of an emotion in the dictionary.
        /// </summary>
        /// <param name="scores">The dictionary storing emotion scores.</param>
        /// <param name="emotionId">The ID of the emotion.</param>
        /// <param name="points">The number of points to add.</param>
        private void AddEmotionScore(Dictionary<int, int> scores, int emotionId, int points)
        {
            if (scores.ContainsKey(emotionId))
            {
                scores[emotionId] += points;
            }
            else
            {
                scores[emotionId] = points;
            }
        }

        #endregion
    }
}
