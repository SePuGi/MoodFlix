namespace MoodFlix.Model.Questionary
{
    public class Option
    {
        public string Text { get; set; }
        public EnumEmotion PrimaryEmotion { get; set; }
        public EnumEmotion SecondaryEmotion { get; set; }
        public EnumEmotion TertiaryEmotion { get; set; }

        public Option(string text, EnumEmotion primaryEmotion, EnumEmotion secondaryEmotion, EnumEmotion tertiaryEmotion)
        {
            Text = text;
            PrimaryEmotion = primaryEmotion;
            SecondaryEmotion = secondaryEmotion;
            TertiaryEmotion = tertiaryEmotion;
        }
    }
}
