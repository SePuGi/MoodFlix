using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoodFlix.Model
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string HorizontalPosterw360 { get; set; }
        public string HorizontalPosterw480 { get; set; }
        public string HorizontalPosterw720 { get; set; }


        [NotMapped] 
        public List<Register> Registers { get; set; }
        [NotMapped]
        public List<GenreMovie> GenreMovies { get; set; }
        [NotMapped]
        public List<DirectorMovie> DirectorMovie { get; set; }
    }
}
