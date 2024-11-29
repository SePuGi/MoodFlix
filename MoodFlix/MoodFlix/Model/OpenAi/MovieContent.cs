using Newtonsoft.Json;

namespace MoodFlix.Model.OpenAi
{
    public class MovieContent
    {
        [JsonProperty("movies")]
        public List<string> Movie { get; set; }
    }
}
