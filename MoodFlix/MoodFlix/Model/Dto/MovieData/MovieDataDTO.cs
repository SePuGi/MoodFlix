using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Text.Json.Serialization;

namespace MoodFlix.Model.Dto.MovieData
{
    public class MovieDataDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(GenreNamesConverter))]//this is to convert the list of genre objects to a list of strings
        public List<string> Genres { get; set; }

        public List<string> Directors { get; set; }
        public int Runtime { get; set; }
        public ImageSet ImageSet { get; set; }
        public StreamingOptions StreamingOptions { get; set; }

    }

    public class ImageSet
    {
        public VerticalPoster VerticalPoster { get; set; }
        public HorizontalPoster HorizontalPoster { get; set; }
    }

    public class StreamingOptions
    {
        public List<StreamingService> ServiceOptions { get; set; }
    }

    public class HorizontalPoster
    {
        public string W360 { get; set; }
        public string W480 { get; set; }
        public string W720 { get; set; }
    }

    public class GenreNamesConverter : Newtonsoft.Json.JsonConverter<List<string>>
    {
        public override List<string> ReadJson(JsonReader reader, Type objectType, List<string> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // Read the JSON array like a object array
            var genres = JArray.Load(reader);

            // Get the name of each genre
            return genres.Select(g => g["name"].ToString()).ToList();
        }

        public override void WriteJson(JsonWriter writer, List<string> value, JsonSerializer serializer)
        {
            // write the genres as an array of strings
            writer.WriteStartArray();
            foreach (var genre in value)
            {
                writer.WriteValue(genre);
            }
            writer.WriteEndArray();
        }
    }
}
