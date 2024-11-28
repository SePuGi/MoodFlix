namespace MoodFlix.Model.Dto.MovieData
{
    public class MoviesWatched
    {
        public string Title { get; set; }

        public override string? ToString()
        {
            return Title;
        }
    }
}
