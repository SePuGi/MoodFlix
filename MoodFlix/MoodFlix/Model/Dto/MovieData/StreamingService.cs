namespace MoodFlix.Model.Dto.MovieData
{
    public class StreamingService
    {
        public string ServiceName { get; set; }
        public string AccesType { get; set; } //Rent, Buy, Stream, subscription
        public string Link { get; set; }
        public ServiceImageSet ImageSet { get; set; }
    }
}
