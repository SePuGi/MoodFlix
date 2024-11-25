using System.ComponentModel.DataAnnotations.Schema;

namespace MoodFlix.Model
{
    public class HistoryEmotion
    {
        //Primary Key
        public int HistoryEmotionId { get; set; }

        //Foreign Key for Register
        public int RegisterId { get; set; }
        [NotMapped] //This attribute is used to exclude the property from the database
        public Register Register { get; set; }

        //Foreign Key for Emotion
        public int EmotionId { get; set; }
        [NotMapped]
        public Emotion Emotion { get; set; }
    }
}
