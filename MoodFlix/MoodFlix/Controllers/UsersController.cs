using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MoodFlix.Model;
using MoodFlix.Model.Dto;
using MoodFlix.Utilities;
using MoodFlix.Wrapper;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MoodFlix.Controllers
{
    [Authorize]//This will make the controller only accessible to authenticated users (JWT)
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public UsersController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        #region UserCRUD-Login-Register
        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.User.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser()
        {
            /*return: 
		{
            userId: int
            name: string
            birthDate: string
            email: string
            genre : 
            [{
		            genreId: int
		            genreName: string
		            isPreferred: bool
            }]
        }
*/
            int id = GetLoggedUserId();
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        //POST: api/Users/register
        [AllowAnonymous] //This will make the endpoint accessible to everyone
        [HttpPost("register")]
        public async Task<ActionResult<User>> RegisterUser(UserRegisterDTO user)
        {
            //check if the password is valid
            if (!Utils.CheckPassword(user.Password))
                return BadRequest();

            //If the password is valid, encrypt it
            user.Password = Utils.EncryptPassword(user.Password);

            //Add the user to the database
            User userDb = new User(user.UserName, user.Email, user.Password, user.BirthDate, user.CountryId);
            _context.User.Add(userDb);

            //save the changes, to get the UserId and save it in the relational tables
            await _context.SaveChangesAsync();

            //Add UserGenres to the database
            foreach (var genre in user.UserGenres)
            {
                _context.UserGenre.Add(new UserGenre { UserId = userDb.UserId, GenreId = genre.Key, IsPreferred = genre.Value });
            }

            //Add UserPlatforms to the database
            foreach (var platform in user.UserPlatforms)
            {
                _context.UserPlatform.Add(new UserPlatform { UserId = userDb.UserId, PlatformId = platform });
            }

            await _context.SaveChangesAsync();

            return CreatedAtAction("RegisterUser", new { id = userDb.UserId });
        }

        //POST: api/Users/login
        [AllowAnonymous] //This will make the endpoint accessible to everyone
        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginUser(UserLoginDTO userLoginDto)
        {
            //Search the user in the database
            userLoginDto.Password = Utils.EncryptPassword(userLoginDto.Password);
            var userDB = await _context.User.FirstOrDefaultAsync(u => u.Email == userLoginDto.Email && u.Password == userLoginDto.Password);

            if (userDB == null)     //User not found
                return NotFound();

            //JWT - Claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, userDB.Email),
                new Claim("UserId", userDB.UserId.ToString())
            };

            //JWT - Token from appsettings.json
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //JWT - Token
            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) }); //return the token
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        #endregion

        #region UserHistory

        /*
         * GET/api/user/{id}
         * GET/api/user/{id}/history
         * POST/api/user/{id}/addToHistory
         * PATCH/api/user/movieRating
         * DELETE/api/user/{id}/history
         */

        #endregion

        #region Utils

        /// <summary>
        /// Add to database the platforms and countrycode of a country
        /// TODO: Check if save the platforms in the database is necessary
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        //GET: api/Platforms/{countryCode}
        [AllowAnonymous]
        [HttpGet("Platforms/{countryCode}")]
        public async Task<ActionResult<IEnumerable<string>>> GetPlatformsByCountry(string countryCode)
        {
            //Get the platforms from "https://streaming-availability.p.rapidapi.com/countries/es?output_language=en"
            
            if(_context.CountryPlatform.Any(cp => cp.CountryCode == countryCode))
            {
                var platforms = _context.CountryPlatform
                    .Where(cp => cp.CountryCode == countryCode)
                    .Select(cp => cp.Platform.PlatformName)
                    .ToList();

                return platforms;
            }
            //Create the request
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://streaming-availability.p.rapidapi.com/countries/" + countryCode + "?output_language=en"),
                Headers =
                {
                    { "x-rapidapi-key", "8a1b5bffbdmsh8cc15e8d1d2a829p1a0b57jsnc839656d1961" },
                    { "x-rapidapi-host", "streaming-availability.p.rapidapi.com" },
                },
            };

            //Send the request
            var response = await new HttpClient().SendAsync(request);

            //Check if the response is successful
            if (response.IsSuccessStatusCode)
            {
                //Get the response
                var responseString = await response.Content.ReadAsStringAsync();

                //Deserialize the response
                var services = JsonConvert.DeserializeObject<ServiceWrapper> (responseString);

                //Get the countryName and the services
                string countryName = services.Name;

                List<string> serviceNames = new List<string>();
                foreach (var service in services.Services)
                {
                    serviceNames.Add(service.Name);
                }

                //Get the countryId
                int countryId = _context.Country.FirstOrDefault(c => c.CountryName == countryName).CountryId;

                //Add the services to the database with the relationship with the country
                foreach (var service in serviceNames)
                {
                    //Check if the service is already in the database
                    if (!_context.Platform.Any(p => p.PlatformName == service))
                    {
                        _context.Platform.Add(new Platform { PlatformName = service });
                        await _context.SaveChangesAsync();
                    }

                    //if the relationship is not already in the database create it
                    if (!_context.CountryPlatform.Any(cp => cp.CountryId == countryId && cp.Platform.PlatformName == service))
                    {
                        _context.CountryPlatform.Add(
                            new CountryPlatform { 
                                CountryId = countryId, 
                                PlatformId = _context.Platform.FirstOrDefault(p => p.PlatformName == service).PlatformId 
                            });
                    }
                }

                await _context.SaveChangesAsync();

                return serviceNames;
            }
            
            return NotFound();
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.UserId == id);
        }
        /// <summary>
        /// Get the logged user id from the token, this user is not in the database, 
        /// is a property of the ControllerBase class in ASP.NET Core 
        /// that represents the authenticated user making the request.
        /// </summary>
        /// <returns></returns>
        private int GetLoggedUserId()
        {
            int idUser = 0;
            try
            {
                idUser = int.Parse(User.FindFirst("UserId").Value);
            }
            catch (Exception e)
            {
                return -1;
            }

            return idUser;
        }

        #endregion
    }
}
