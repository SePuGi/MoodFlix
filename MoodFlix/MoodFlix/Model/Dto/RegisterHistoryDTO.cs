namespace MoodFlix.Model.Dto
{
    public class RegisterHistoryDTO
    {
        public int RegisterId { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public List<string> EmotionName { get; set; }
        public MovieHistoryDTO Movie { get; set; }
        public int? MovieRating { get; set; }
    }
}
