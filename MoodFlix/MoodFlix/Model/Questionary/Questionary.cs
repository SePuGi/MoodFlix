namespace MoodFlix.Model.Questionary
{
    public class Questionary
    {
        public List<Question> Questions { get; set; }

        public Questionary()
        {
            Questions = new List<Question>();
        }
    }
}
