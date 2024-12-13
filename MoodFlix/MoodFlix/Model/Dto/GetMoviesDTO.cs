namespace MoodFlix.Model.Dto
{
    public class GetMoviesDTO
    {
        public List<string> MoviesSuggested { get; set; } = new List<string>();

        //Emotion the user want to feel watching the movie, by default is null
        public int? EmotionId { get; set; } = null; //emotion the user want to feel while watching the movie

        //List of emotions the user feel in the moment (only used in getMoviesByEmotions), by default is null
        public List<int>? EmotionsId { get; set; } = null;
    }
}
