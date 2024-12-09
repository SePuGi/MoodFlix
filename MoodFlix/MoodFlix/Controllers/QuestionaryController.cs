using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using MoodFlix.Model;
using MoodFlix.Model.Dto;
using MoodFlix.Model.Dto.MovieData;
using MoodFlix.Model.OpenAi;
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
    [Route("api/[controller]")]
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
            int userId = /*GetLoggedUserId();*/ 1;

            //if (userId == -1)
            //    return Unauthorized("User not found");

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
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SubmitQuestionary([FromBody] List<QuestionaryResponseDTO> responses)
        {
            int userId = /*GetLoggedUserId();*/ 1;

            //if (userId == -1)
            //    return Unauthorized("User not found");

            if (responses == null || responses.Count == 0)
            {
                return BadRequest("The questionary responses are invalid or empty.");
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

            List<EmotionDTO> sortedEmotions = CalculateEmotions(emotionScores, responses);

            var description = await GetEmotionDescriptionOpenAI(userId, sortedEmotions);

            var emotionDescription = new EmotionDescriptionDTO
            {
                Emotions = sortedEmotions,
                Description = description
            };
            // Return the calculated emotions
            return Ok(emotionDescription);
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

        /// <summary>
        /// Calculates the top three emotions based on the given emotion scores.
        /// </summary>
        /// <param name="emotionScores">A dictionary containing emotion IDs as keys and their corresponding scores as values.</param>
        /// <returns>A list of EmotionDTO objects representing the top emotions, including one truncal emotion and two secondary emotions.</returns>
        private List<EmotionDTO> CalculateEmotions(Dictionary<int, int> emotionScores, List<QuestionaryResponseDTO> responses)
        {
            // Get the 4 truncal emotions
            List<int> truncalEmotions = new List<int> { (int)EnumEmotion.Joy, (int)EnumEmotion.Sadness, (int)EnumEmotion.Fear, (int)EnumEmotion.Anger };

            // Calculate the score of each truncal emotion
            var truncalScores = emotionScores
                .Where(e => truncalEmotions.Contains(e.Key))
                .OrderByDescending(e => e.Value)
                .ToList();

            // Handle tie in truncal emotions
            var maxScore = truncalScores.First().Value;
            var topTruncals = truncalScores.Where(e => e.Value == maxScore).ToList();

            int selectedTruncalId;
            if (topTruncals.Count > 1)
            {
                // Count secondary emotions frequencies for each truncal
                var secondaryFrequencyMap = new Dictionary<int, Dictionary<int, int>>();

                foreach (var truncal in topTruncals)
                {
                    secondaryFrequencyMap[truncal.Key] = new Dictionary<int, int>();

                    foreach (var response in responses)
                    {
                        var question = _questionary.Questions.FirstOrDefault(q => q.Text == response.Question);
                        var selectedOption = question?.Options.FirstOrDefault(o => o.Key == response.Answer);

                        if (selectedOption != null && (int)selectedOption.PrimaryEmotion == truncal.Key)
                        {
                            int secondary = (int)selectedOption.SecondaryEmotion;
                            int tertiary = (int)selectedOption.TertiaryEmotion;

                            // Increment frequency counts
                            if (!secondaryFrequencyMap[truncal.Key].ContainsKey(secondary))
                                secondaryFrequencyMap[truncal.Key][secondary] = 0;

                            if (!secondaryFrequencyMap[truncal.Key].ContainsKey(tertiary))
                                secondaryFrequencyMap[truncal.Key][tertiary] = 0;

                            secondaryFrequencyMap[truncal.Key][secondary]++;
                            secondaryFrequencyMap[truncal.Key][tertiary]++;
                        }
                    }
                }

                // Determine the truncal emotion with the most frequent associated emotion
                selectedTruncalId = topTruncals
                    .Select(truncal => new
                    {
                        TruncalId = truncal.Key,
                        MaxFrequency = secondaryFrequencyMap[truncal.Key].MaxBy(e => e.Value).Value
                    })
                    .OrderByDescending(e => e.MaxFrequency)
                    .ThenBy(e => truncalEmotions.IndexOf(e.TruncalId)) // Fallback to predefined order
                    .First()
                    .TruncalId;
            }
            else
            {
                selectedTruncalId = topTruncals.First().Key;
            }


            // Sort emotions which are not truncal emotions (2 secondary emotions)
            var otherEmotions = emotionScores
                .Where(e => !truncalEmotions.Contains(e.Key))
                .OrderByDescending(e => e.Value)
                .Take(2);

            // Combine truncal emotion with the rest
            List<EmotionDTO> sortedEmotions = new List<EmotionDTO>
            {
                new EmotionDTO
                {
                    Id = selectedTruncalId,
                    Name = ((EnumEmotion)selectedTruncalId).ToString(),
                    Score = emotionScores[selectedTruncalId]
                }
            };

            sortedEmotions.AddRange(otherEmotions.Select(e => new EmotionDTO
            {
                Id = e.Key,
                Name = ((EnumEmotion)e.Key).ToString(),
                Score = e.Value
            }));

            return sortedEmotions;
        }

        /// <summary>
        /// Sends a request to the OpenAI API to get a description of emotions based on the user's emotional state.
        /// </summary>
        /// <param name="userId">The unique identifier of the user requesting the emotion description.</param>
        /// <param name="emotions">A list of EmotionDTO objects representing the top emotions of the user.</param>
        /// <returns>A task that represents the asynchronous operation, with a string result containing the description of the emotions provided by OpenAI.</returns>
        private async Task<string> GetEmotionDescriptionOpenAI(int userId, List<EmotionDTO> emotions)
        {
            string openAIKey = Utils.GetApiKey("OpenAI");
            string apiEndpoint = "https://api.openai.com/v1/chat/completions";

            List<Message> prompt = new List<Message>();
            prompt = await CreatePrompt(userId, emotions);

            //Prompt
            RequestOpenAi request = new RequestOpenAi()
            {
                Model = "gpt-3.5-turbo", //gpt-4o-mini        gpt-3.5-turbo
                Messages = prompt,
                MaxTokens = 100,
                Temperature = 0.6f
            };

            //Create the request
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {openAIKey}");

            var json = System.Text.Json.JsonSerializer.Serialize(request);
            var body = new StringContent(json, Encoding.UTF8, "application/json");

            //Send the request
            var response = await client.PostAsync(apiEndpoint, body);

            string emotionsDescriptionResponse = "";

            if (response.IsSuccessStatusCode)
            {
                //Get the response
                var responseString = await response.Content.ReadAsStringAsync();

                //Get the content from the response using RequestOpenAi class
                var responseObj = JsonConvert.DeserializeObject<ResponseOpenAi>(responseString);

                //Get the description from the response (responseObj.Choices[0].Message.Content) <- this is a string with the description of the emotion
                var description = responseObj.Choices[0].Message.Content;

                emotionsDescriptionResponse = description;
            }

            //response
            return emotionsDescriptionResponse;
        }

        /// <summary>
        /// Creates a prompt for the OpenAI API based on the user's emotional state, including their age and emotion scores.
        /// </summary>
        /// <param name="userId">The unique identifier of the user for fetching their birth date and calculating their age.</param>
        /// <param name="emotions">A list of EmotionDTO objects representing the user's top emotions, including a primary basic emotion and two secondary emotions with their respective scores.</param>
        /// <returns>A task that represents the asynchronous operation, with a list of Message objects to be used as input for the OpenAI API request.</returns>
        private async Task<List<Message>> CreatePrompt(int userId, List<EmotionDTO> emotions)
        {
            List<Message> message = new List<Message>();

            //Add conversation context (you are a psychology expert...)
            new Message() { Role = "system", Content = "You are analyzing emotions derived from a questionnaire. Each emotion has a score indicating its intensity. The input consists of a primary basic emotion (Joy, Sadness, Fear, or Anger) and two secondary emotions, along with their respective scores."};

            //Add the age of the user
            var birthDate = _context.User.Where(u => u.UserId == userId).Select(u => u.BirthDate).FirstOrDefault();
            var age = DateTime.Now.Year - birthDate.Year;

            message.Add(new Message() { Role = "system", Content = $"I am {age} years old" });

            //Add emotions to the prompt with its scores
            var basicEmotion = emotions[0];
            var secondaryEmotions = emotions.Skip(1); // Skipping the first item (basic emotion)

            string secondaryEmotionsText = string.Join(", ", secondaryEmotions.Select(e => $"{e.Name} (Score: {e.Score})"));

            message.Add(new Message()
            {
                Role = "system",
                Content = $"Basic Emotion: {basicEmotion.Name} (Score: {basicEmotion.Score})\r\nSecondary Emotions: {secondaryEmotionsText}\r\n\""
            });

            //Generate string with the description
            message.Add(new Message() { Role = "user", Content = @"Based on the input:
- Provide a brief and empathetic explanation of the emotional state.
- Describe the significance of the primary emotion and how the secondary emotions, influenced by their scores, relate to the primary emotion.
- Maximum of 40 words
" });

            return message;
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
