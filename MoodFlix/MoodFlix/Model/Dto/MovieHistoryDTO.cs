using MoodFlix.Model.Dto.MovieData;

namespace MoodFlix.Model.Dto
{
    public class MovieHistoryDTO
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Directors { get; set; }
        public HorizontalPoster HorizontalPoster { get; set; }
    }
}
