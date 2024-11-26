using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace MoodFlix.Utilities
{
    public class Utils
    {
        /// <summary>
        /// Encrypt the password using SHA256
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// check if the password is valid
        /// password must have at least:
        ///     8 characters, 
        ///     1 uppercase, 
        ///     1 lowercase, 
        ///     1 number, 
        ///     1 special character
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CheckPassword(string password)
        {
             Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            return regex.IsMatch(password);
        }

        /// <summary>
        /// Get the API key from the keys.xml file
        /// </summary>
        /// <param name="apiName"></param>
        /// <returns></returns>
        public static string GetApiKey(string apiName)
        {
            /*
             * keys.xml file structure
             * 
             * <ApiKey>
             *     <API name="OpenAI">
             *         <key>OpenAI_Key</key>
             *     </API>
             *     <API name="StreamingAvailability">
             *         <key>StreamingAvailability_Key</key>
             *     </API>
             * </ApiKey>
             */

            string path = Path.Combine(Directory.GetCurrentDirectory(), "API_KEYS/keys.xml");
            string keysXml = System.IO.File.ReadAllText(path);

            string Key = XElement.Parse(keysXml).Elements("API").Where(x => x.Attribute("name").Value == apiName).Select(x => x.Element("key").Value).FirstOrDefault();

            return Key;
        }
    }
}
