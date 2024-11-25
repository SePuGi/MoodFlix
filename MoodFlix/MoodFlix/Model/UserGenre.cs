using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MoodFlix.Model
{
    public class UserGenre
    {
        public int UserId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public User User { get; set; }

        public int GenreId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public Genre Genre { get; set; }

        public bool IsPreferred { get; set; }
    }
}
