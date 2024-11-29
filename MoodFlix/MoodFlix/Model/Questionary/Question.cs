namespace MoodFlix.Model.Questionary
{
    public class Question
    {
        public string Text { get; set; }
        public List<Option> Options { get; set; }

        public Question(string text)
        {
            Text = text;
            Options = new List<Option>();
        }

        public Question()
        {
            Options = new List<Option>();
        }
    }
}
