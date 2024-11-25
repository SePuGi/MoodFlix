using System.ComponentModel.DataAnnotations.Schema;

namespace MoodFlix.Model
{
    public class GenreMovie
    {
        public int GenreId { get; set; }
        [NotMapped]
        public Genre Genre { get; set; }

        public int MovieId { get; set; }
        [NotMapped]
        public Movie Movie { get; set; }
    }
}
