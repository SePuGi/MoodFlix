using System.Text.Json.Serialization;

namespace MoodFlix.Model.OpenAi
{
    public class RequestOpenAi
    {
        [JsonPropertyName("model")]
        public string Model { get; set; }
        [JsonPropertyName("messages")]
        public List<Message> Messages { get; set; }
        [JsonPropertyName("max_tokens")]
        public int MaxTokens { get; set; }
        [JsonPropertyName("temperature")]
        public float Temperature { get; set; }
    }
}
