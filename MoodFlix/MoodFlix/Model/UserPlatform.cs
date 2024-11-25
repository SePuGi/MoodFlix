using System.ComponentModel.DataAnnotations.Schema;

namespace MoodFlix.Model
{
    public class UserPlatform
    {
        public int UserId { get; set; }
        [NotMapped]
        public User User { get; set; }

        public int PlatformId { get; set; }
        [NotMapped]
        public Platform Platform { get; set; }
    }
}
