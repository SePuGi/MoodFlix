namespace MoodFlix.Model.OpenAi
{
    public class RequestOpenAi
    {
        public string Model { get; set; }
        public List<Message> Messages { get; set; }
        public int MaxTokens { get; set; }
        public float Temperature { get; set; }
    }
}
