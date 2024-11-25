using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MoodFlix.Model
{
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }

        // This is a one-to-many relationship
        [JsonIgnore]
        public List<UserPlatform> UserPlatforms { get; set; }
        // This is a one-to-many relationship
        [JsonIgnore]
        public List<CountryPlatform> CountryPlatforms { get; set; }
    }
}
