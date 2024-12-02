namespace MoodFlix.Model.Dto
{
    public class UserPreferencesDTO
    {
        public List<UserGenreDTO> Genres { get; set; }
        public List<Platform> Platforms { get; set; }
    }
}
