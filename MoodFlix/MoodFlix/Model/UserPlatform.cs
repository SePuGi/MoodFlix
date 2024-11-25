using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MoodFlix.Model
{
    public class UserPlatform
    {
        public int UserId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public User User { get; set; }

        public int PlatformId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public Platform Platform { get; set; }
    }
}
