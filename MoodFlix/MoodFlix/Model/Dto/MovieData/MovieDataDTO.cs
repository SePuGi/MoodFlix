namespace MoodFlix.Model.Dto.MovieData
{
    public class MovieDataDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Directors { get; set; }
        public int Runtime { get; set; }
        public ImageSet ImageSet { get; set; }
        public StreamingOptions StreamingOptions { get; set; }
    }

    public class ImageSet
    {
        public VerticalPoster VerticalPoster { get; set; }
    }

    public class StreamingOptions
    {
        public List<StreamingService> ServiceOptions { get; set; }
    }


}
