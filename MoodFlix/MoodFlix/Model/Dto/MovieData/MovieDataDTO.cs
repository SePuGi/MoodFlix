namespace MoodFlix.Model.Dto.MovieData
{
    public class MovieDataDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public List<Genre> Genres { get; set; }
        public List<string> Directors { get; set; }
        public int Runtime { get; set; }
        public ImageSet ImageSet { get; set; }
        public StreamingOptions StreamingOptions { get; set; }
    }

    public class Genre
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class ImageSet
    {
        public VerticalPoster VerticalPoster { get; set; }
    }

    public class VerticalPoster
    {
        public string W240 { get; set; }
        public string W360 { get; set; }
        public string W480 { get; set; }
    }

    public class StreamingOptions
    {
        public List<StreamingService> Us { get; set; }
        public List<StreamingService> Es { get; set; }
        public List<StreamingService> Ar { get; set; }
        public List<StreamingService> Pe { get; set; }
    }

    public class StreamingService
    {
        public Service Service { get; set; }
    }

    public class Service
    {
        public string Name { get; set; }
    }
}
