namespace MoodFlix.Model.Dto
{
    public class RegisterHistoryDTO
    {
        public int RegisterId { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string EmotionName { get; set; }
    }
}
