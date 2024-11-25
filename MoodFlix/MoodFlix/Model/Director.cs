using System.ComponentModel.DataAnnotations;

namespace MoodFlix.Model
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }

        public List<DirectorMovie> DirectorMovies { get; set; }
    }
}
