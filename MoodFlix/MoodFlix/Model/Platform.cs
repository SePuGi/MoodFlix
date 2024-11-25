using System.ComponentModel.DataAnnotations;

namespace MoodFlix.Model
{
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }

        // This is a one-to-many relationship
        public List<UserPlatform> UserPlatforms { get; set; }
    }
}
