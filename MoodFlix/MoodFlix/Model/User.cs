using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MoodFlix.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }        
        public DateTime BirthDate { get; set; }

        //Foreign Key to Country
        public int CountryId { get; set; }
        [JsonIgnore]
        public Country? Country { get; set; }       


        //This does not create a column in the database, only is used to set the relationship
        [JsonIgnore]
        public List<UserPlatform> UserPlatforms { get; set; } = new List<UserPlatform>();   // List of platforms the user has access to

        //This does not create a column in the database, only is used to set the relationship
        [JsonIgnore]
        public List<UserGenre> UserGenres { get; set; } = new List<UserGenre>();// List of genres the user likes or dislikes

        //This does not create a column in the database, only is used to set the relationship
        [JsonIgnore]
        public List<Register> History { get; set; } = new List<Register>();

        public User(string userName, string email, string password, DateTime birthDate, int countryId)
        {
            UserName = userName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            CountryId = countryId;
        }

        public User(int userId, string userName, string email, string password, DateTime birthDate, int countryId)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            CountryId = countryId;
        }
    }
}
