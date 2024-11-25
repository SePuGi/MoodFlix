using System.ComponentModel.DataAnnotations;

namespace MoodFlix.Model
{
    public class Emotion
    {
        [Key]
        public int EmotionId { get; set; }
        public string EmotionName { get; set; }

        // This is a one-to-many relationship
        public List<HistoryEmotion> HistoryEmotions { get; set; }
    }
}
