using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MoodFlix.Model
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }

        // This is a one-to-many relationship
        [JsonIgnore]
        public List<UserGenre> UserGenres { get; set; }

        // This is a one-to-many relationship
        [JsonIgnore]
        public List<GenreMovie> GenreMovies { get; set; }
    }
}
