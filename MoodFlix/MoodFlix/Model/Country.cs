using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MoodFlix.Model
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        //This does not create a column in the database, only is used to set the relationship
        [JsonIgnore]
        public List<User> Users { get; set; }
        [JsonIgnore]
        public List<CountryPlatform> CountryPlatforms { get; set; }
    }
}
