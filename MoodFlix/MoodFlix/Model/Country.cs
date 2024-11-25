using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoodFlix.Model
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        //This does not create a column in the database, only is used to set the relationship
        public List<User> Users { get; set; }
    }
}
