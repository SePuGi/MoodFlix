namespace MoodFlix.Model.Dto
{
    public class RegisterDTO
    {
        //Movie {All_movie_info, director/s, genre/s},
        //UserId
        //EmotionId
        //Rating
        //Date

        public MovieInfoDTO MovieInfo { get; set; }
        public int UserId { get; set; }
        public int EmotionId { get; set; }
        public int? Rating { get; set; }     //At first, this value will be null
        public DateTime Date { get; set; }  //Date of the register
    }
}
