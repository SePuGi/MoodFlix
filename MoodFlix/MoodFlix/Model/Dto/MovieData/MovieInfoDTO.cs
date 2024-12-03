namespace MoodFlix.Model.Dto.MovieData
{
    public class MovieInfoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Directors { get; set; }
        public int Runtime { get; set; }
        public ImageSet ImageSet { get; set; }
        public StreamingOptions StreamingOptions { get; set; }

        public List<int> EmotionId { get; set; }
    }
}
