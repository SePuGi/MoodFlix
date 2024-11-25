using System.ComponentModel.DataAnnotations.Schema;

namespace MoodFlix.Model
{
    public class UserGenre
    {
        public int UserId { get; set; }
        [NotMapped]
        public User User { get; set; }

        public int GenreId { get; set; }
        [NotMapped]
        public Genre Genre { get; set; }

        public bool IsPreferred { get; set; }
    }
}
