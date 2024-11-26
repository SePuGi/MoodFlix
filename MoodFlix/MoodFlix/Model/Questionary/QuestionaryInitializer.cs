namespace MoodFlix.Model.Questionary
{
    public static class QuestionaryInitializer
    {
        public static Questionary CreateQuestionary()
        {
            var questionary = new Questionary();

            //First question
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

            //Second Question
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

            //Third question
            questionary.Questions.Add(new Question("How do you feel emotionally when facing a new or unexpected situation?")
            {
                Options = new List<Option>
                {
                    new Option("I explore with excitement and curiosity", EnumEmotion.Amazement, EnumEmotion.Joy, EnumEmotion.Interest),
                    new Option("I do my best, despite my nervousness", EnumEmotion.Anxiety, EnumEmotion.Interest, EnumEmotion.Fear),
                    new Option("I feel confused and find it hard to decide what to do", EnumEmotion.Confusion, EnumEmotion.Boredom, EnumEmotion.Sadness),
                    new Option("I face the situation with calm and confidence", EnumEmotion.Calmness, EnumEmotion.Satisfaction, EnumEmotion.Sympathy)
                }
            });

            // Forth Question
            questionary.Questions.Add(new Question("How do you feel when receiving good news or achievements?")
            {
                Options = new List<Option>
                {
                    new Option("I celebrate openly and share my joy", EnumEmotion.Joy, EnumEmotion.Satisfaction, EnumEmotion.Triumph),
                    new Option("I smile and quietly express gratitude", EnumEmotion.Satisfaction, EnumEmotion.Joy, EnumEmotion.Love),
                    new Option("I express my surprise with enthusiasm", EnumEmotion.Ecstasy, EnumEmotion.Amazement, EnumEmotion.Admiration),
                    new Option("I don’t give much importance to the event", EnumEmotion.Boredom, EnumEmotion.Sadness, EnumEmotion.Disgust)
                }
            });

            // Fifth question
            questionary.Questions.Add(new Question("How do you feel when facing a stressful or challenging situation?")
            {
                Options = new List<Option>
                {
                    new Option("I face the challenge even though I am nervous.", EnumEmotion.Anxiety, EnumEmotion.Fear, EnumEmotion.Interest),
                    new Option("I remain calm and focus on finding a solution.", EnumEmotion.Calmness, EnumEmotion.Satisfaction, EnumEmotion.Triumph),
                    new Option("I complain or react with anger.", EnumEmotion.Anger, EnumEmotion.Fear, EnumEmotion.Anxiety),
                    new Option("I give up and lose interest in continuing.", EnumEmotion.Boredom, EnumEmotion.Sadness, EnumEmotion.Disgust)
                }
            });

            // Sixth question
            questionary.Questions.Add(new Question("When facing a difficulty or problem, how do you react?")
            {
                Options = new List<Option>
                {
                    new Option("I solve the problem with patience.", EnumEmotion.Calmness, EnumEmotion.Satisfaction, EnumEmotion.Triumph),
                    new Option("I feel too weak to continue.", EnumEmotion.Sadness, EnumEmotion.Boredom, EnumEmotion.Disgust),
                    new Option("I vent my frustration in the moment.", EnumEmotion.Anger, EnumEmotion.Anxiety, EnumEmotion.Fear),
                    new Option("I think of creative and possible solutions.", EnumEmotion.Interest, EnumEmotion.Joy, EnumEmotion.Admiration)
                }
            });

            // Seventh question
            questionary.Questions.Add(new Question("How do you feel right now about the people you care about?")
            {
                Options = new List<Option>
                {
                    new Option("I express closeness and affection toward them.", EnumEmotion.Love, EnumEmotion.Sympathy, EnumEmotion.Satisfaction),
                    new Option("I let them know that something about their behavior bothers me.", EnumEmotion.Anger, EnumEmotion.Anxiety, EnumEmotion.Fear),
                    new Option("I remain indifferent and avoid getting too involved.", EnumEmotion.Boredom, EnumEmotion.Sadness, EnumEmotion.Confusion),
                    new Option("I think about different emotions regarding them.", EnumEmotion.Confusion, EnumEmotion.Interest, EnumEmotion.Nostalgia)
                }
            });

            // Eighth question
            questionary.Questions.Add(new Question("How do you feel when you see someone going through a difficult time?")
            {
                Options = new List<Option>
    {
        new Option("I try to help and offer emotional support.", EnumEmotion.EmpathicPain, EnumEmotion.Sympathy, EnumEmotion.Love),
        new Option("I reflect on their situation and feel sad for them.", EnumEmotion.Sadness, EnumEmotion.EmpathicPain, EnumEmotion.Nostalgia),
        new Option("I carry on with my own life and don’t get too involved.", EnumEmotion.Boredom, EnumEmotion.Confusion, EnumEmotion.Disgust),
        new Option("I feel uncomfortable and prefer to avoid the situation.", EnumEmotion.Fear, EnumEmotion.Anxiety, EnumEmotion.Anger)
    }
            });

            // Ninth question
            questionary.Questions.Add(new Question("How do you feel right now about your own achievements or efforts?")
            {
                Options = new List<Option>
                {
                    new Option("I celebrate my achievements and share my satisfaction.", EnumEmotion.Triumph, EnumEmotion.Satisfaction, EnumEmotion.Joy),
                    new Option("I blame myself for not doing more.", EnumEmotion.Sadness, EnumEmotion.Boredom, EnumEmotion.Anger),
                    new Option("I am excited about what I can accomplish next.", EnumEmotion.Anxiety, EnumEmotion.Fear, EnumEmotion.Interest),
                    new Option("I remain neutral and don’t think much about it.", EnumEmotion.Disgust, EnumEmotion.Boredom, EnumEmotion.Confusion)
                }
            });

            // Tenth question
            questionary.Questions.Add(new Question("How would you describe your emotional state when facing an unexpected high-pressure situation?")
            {
                Options = new List<Option>
                {
                    new Option("I act with determination and confidence.", EnumEmotion.Calmness, EnumEmotion.Triumph, EnumEmotion.Satisfaction),
                    new Option("I feel overwhelmed and extremely worried.", EnumEmotion.Anxiety, EnumEmotion.Fear, EnumEmotion.Anger),
                    new Option("I face the pressure with discomfort, but without giving up.", EnumEmotion.Fear, EnumEmotion.Anxiety, EnumEmotion.Confusion),
                    new Option("I freeze and feel like I have no control.", EnumEmotion.Boredom, EnumEmotion.Disgust, EnumEmotion.Sadness)
                }
            });
            return questionary;
        }
    }
}
