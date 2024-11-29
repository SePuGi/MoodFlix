namespace MoodFlix.Model.OpenAi
{
    public class ResponseOpenAi
    {
        public List<Choice> Choices { get; set; }
    }

    public class Choice
    {
        public MessageContent Message { get; set; }
    }

    public class MessageContent
    {
        public string Content { get; set; }
    }
}
