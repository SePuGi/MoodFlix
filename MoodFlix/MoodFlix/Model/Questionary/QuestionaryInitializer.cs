namespace MoodFlix.Model.Questionary
{
    public static class QuestionaryInitializer
    {
        public static Questionary CreateQuestionnaire()
        {
            var questionary = new Questionary();

            questionary.Questions.Add(new Question("How would you describe your emotional connection with the immediate environment?")
            {
                Options = new List<Option>
                {
                    new Option("I take time to observe and relax in the moment", EnumEmotion.Calmness, EnumEmotion.Satisfaction, EnumEmotion.Sympathy),
                    new Option("I think about everything I have to do and worry", EnumEmotion.Anxiety, EnumEmotion.Fear, EnumEmotion.Anger),
                    new Option("I’m interested in exploring what’s happening", EnumEmotion.Interest, EnumEmotion.Joy, EnumEmotion.Admiration),
                    new Option("I feel disconnected and prefer to isolate myself.", EnumEmotion.Sadness, EnumEmotion.Boredom, EnumEmotion.Confusion)
                }
            });

            questionary.Questions.Add(new Question("How do you feel about the people around you right now?")
            {
                Options = new List<Option>
                {
                    new Option("I express closeness and affection toward them", EnumEmotion.Love, EnumEmotion.Sympathy, EnumEmotion.Satisfaction),
                    new Option("I remain silent, preferring not to interact", EnumEmotion.Boredom, EnumEmotion.Sadness, EnumEmotion.Confusion),
                    new Option("I observe and admire certain people", EnumEmotion.Admiration, EnumEmotion.Joy, EnumEmotion.Interest),
                    new Option("I express frustration with my words or actions", EnumEmotion.Anger, EnumEmotion.Anxiety, EnumEmotion.Fear)
                }
            });

            questionary.Questions.Add(new Question("")
            {
                Options = new List<Option>
                {
                    new Option("I explore with excitement and curiosity", EnumEmotion.Amazement, EnumEmotion.Joy, EnumEmotion.Interest),
                    new Option("I do my best, despite my nervousness", EnumEmotion.Anxiety, EnumEmotion.Ho, EnumEmotion.Fear)
                }
            });

            return questionary;
        }
    }
}
