using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MoodFlix.Model
{
    public class Register
    {
        [Key]
        public int RegisterId { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }

        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }

        //Relation with HistoryEmotion 1:N
        [NotMapped]
        public List<HistoryEmotion> HistoryEmotions { get; set; }
        

        public int MovieId { get; set; }
        [JsonIgnore]
        [NotMapped]
        public Movie Movie { get; set; }

        public Register(int registerId, int movieId, int userId, DateTime date, int rating)
        {
            RegisterId = registerId;
            MovieId = movieId;
            UserId = userId;
            Date = date;
            Rating = rating;
        }

        public Register()
        {
        }
    }
}
