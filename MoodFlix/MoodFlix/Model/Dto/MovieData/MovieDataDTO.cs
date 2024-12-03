using System.Text.Json.Serialization;

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
        public HorizontalPoster HorizontalPoster { get; set; }
    }

    public class StreamingOptions
    {
        public List<StreamingService> ServiceOptions { get; set; }
    }

    public class HorizontalPoster
    {
        public string W360 { get; set; }
        public string W480 { get; set; }
        public string W720 { get; set; }
    }


}
