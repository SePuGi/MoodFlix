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
    [Authorize]//This will make the controller only accessible to authenticated users (JWT)
    [Route("api/questionary")]
    [ApiController]
    public class QuestionaryController : ControllerBase
    {
        private readonly Questionary _questionary;

        public QuestionaryController()
        {
            _questionary = QuestionaryInitializer.CreateQuestionary();
        }

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
        public IActionResult SubmitAnswers([FromBody] List<int> selectedAnswers)
        {
            if (selectedAnswers == null || selectedAnswers.Count != _questionary.Questions.Count)
                return BadRequest("Invalid number of answers");

            // Calculate scores
            var scores = new Dictionary<EnumEmotion, int>();

            for (int i = 0; i < selectedAnswers.Count; i++)
            {
                var question = _questionary.Questions[i];
                var selectedOption = question.Options[selectedAnswers[i]];

                void AddPoints(EnumEmotion emotion, int points)
                {
                    if (!scores.ContainsKey(emotion))
                        scores[emotion] = 0;
                    scores[emotion] += points;
                }

                AddPoints(selectedOption.PrimaryEmotion, 3);
                AddPoints(selectedOption.SecondaryEmotion, 2);
                AddPoints(selectedOption.TertiaryEmotion, 1);
            }

            // Determine top 4 emotions
            var topEmotions = scores
                .OrderByDescending(e => e.Value)
                .TakeWhile((e, index) =>
                    index < 4 || (index > 0 && e.Value == scores.ElementAt(index - 1).Value))
                .Select(e => new { Emotion = e.Key.ToString(), Score = e.Value })
                .ToList();

            return Ok(topEmotions);
        }
    }
}
