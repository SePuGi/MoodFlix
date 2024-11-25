using System.Text.Json.Serialization;

namespace MoodFlix.Model
{
    public class CountryPlatform
    {
        public int CountryId { get; set; }
        [JsonIgnore]
        public Country Country { get; set; }

        public int PlatformId { get; set; }
        [JsonIgnore]
        public Platform Platform { get; set; }

        public string CountryCode { get; set; }
    }
}
