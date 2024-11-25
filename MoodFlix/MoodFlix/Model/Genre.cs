using System.ComponentModel.DataAnnotations;

namespace MoodFlix.Model
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }

        // This is a one-to-many relationship
        public List<UserGenre> UserGenres { get; set; }

        // This is a one-to-many relationship
        public List<GenreMovie> GenreMovies { get; set; }
    }
}
