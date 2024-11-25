using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Country Country { get; set; }       


        //This does not create a column in the database, only is used to set the relationship
        public List<UserPlatform> UserPlatforms { get; set; }  // List of platforms the user has access to

        //This does not create a column in the database, only is used to set the relationship
        public List<UserGenre> UserGenres { get; set; } // List of genres the user likes or dislikes

        //This does not create a column in the database, only is used to set the relationship
        public List<Register> History { get; set; }

    }
}
