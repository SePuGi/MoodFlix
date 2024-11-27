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

        public QuestionaryController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _questionary = QuestionaryInitializer.CreateQuestionary();
        }
        private readonly Questionary _questionary;

        [HttpGet]
        public IActionResult GetQuestionnaire()
        {
            var response = _questionary.Questions.Select(q => new
            {
                question = q.Text,
                answers = q.Options.Select(o => o.Text).ToList()
            }).ToList();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult SubmitQuestionnaire([FromBody] List<QuestionaryResponseDTO> responses, [FromQuery] int registerId)
        {
            if (responses == null || responses.Count == 0)
            {
                return BadRequest("The questionnaire responses are invalid or empty.");
            }

            // Dictionay to get sum of scores of emotions
            var emotionScores = new Dictionary<int, int>();

            foreach (var response in responses)
            {
                // Find the correct question
                var question = _questionary.Questions.FirstOrDefault(q => q.Text == response.Question);
                if (question == null)
                {
                    return NotFound($"Question '{response.Question}' not found.");
                }

                // Find the option selected by the user
                var selectedOption = question.Options.FirstOrDefault(o => o.Text == response.Answer);
                if (selectedOption == null)
                {
                    return NotFound($"Answer '{response.Answer}' for question '{response.Question}' not found.");
                }

                // Sum scores of emotions
                AddEmotionScore(emotionScores, (int)selectedOption.PrimaryEmotion, 3); // Primary: 3 points
                AddEmotionScore(emotionScores, (int)selectedOption.SecondaryEmotion, 2); // Secondary: 2 points
                AddEmotionScore(emotionScores, (int)selectedOption.TertiaryEmotion, 1); // Tertiary: 1 point
            }

            // Order emotions by score (max  to min)
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

            //// Save emotions with its scores in history
            //foreach (var emotion in sortedEmotions)
            //{
            //    var historyEmotion = new HistoryEmotion
            //    {
            //        RegisterId = registerId, 
            //        EmotionId = emotion.EmotionId 
            //    };

            //    _context.HistoryEmotion.Add(historyEmotion); 
            //}

            //_context.SaveChanges();


            var firstEmotion = sortedEmotions.FirstOrDefault();

            // Return only first emotion
            return Ok(sortedEmotions);
        }

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
    }
}
