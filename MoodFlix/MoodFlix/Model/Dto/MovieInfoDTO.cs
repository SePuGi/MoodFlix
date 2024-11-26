namespace MoodFlix.Model.Dto
{
    public class MovieInfoDTO
    {
        /*
         * title
         * overview
         * horizontalPosterw360
         * horizontalPosterw480
         * horizontalPosterw720
         * 
         */
        public Movie Movie { get; set; }

        /*
         * directorName
         */
        public List<Director> Directors { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
