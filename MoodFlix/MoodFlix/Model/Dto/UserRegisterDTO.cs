namespace MoodFlix.Model.Dto
{
    public class UserRegisterDTO
    {
        /*
         * POST: Example
        {
          "userName": "Sergi",
          "email": "sergi@gmail.com",
          "password": "Passw0rd!",
          "birthDate": "1999-12-23",
          "countryId": 108,
          "userPlatforms": [1, 2, 3],  
          "userGenres": {
            "6": true, 
            "8": false  
          }
        }
    */
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public int CountryId { get; set; }

        // Key: GenreId, Value: IsPreferred
    }
}
