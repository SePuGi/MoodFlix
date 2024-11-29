using MoodFlix.Utilities;

namespace MoodFlix.Model.Questionary
{
    public static class QuestionaryInitializer
    {
        public static Questionary CreateQuestionary()
        {
            Questionary questionary = Utils.GetQuestionaryFromXml();
            return questionary;
        }
    }
}
