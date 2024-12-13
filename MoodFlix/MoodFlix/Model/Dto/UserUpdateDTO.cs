namespace MoodFlix.Model.Dto
{
    public class UserUpdateDTO
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? CountryId { get; set; }
    }
}
