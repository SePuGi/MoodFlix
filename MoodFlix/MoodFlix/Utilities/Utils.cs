using MoodFlix.Model.Questionary;
using MoodFlix.Model;
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

            string path = Path.Combine(Directory.GetCurrentDirectory(), "res/API_KEYS/keys.xml");
            string keysXml = System.IO.File.ReadAllText(path);

            string Key = XElement.Parse(keysXml).Elements("API").Where(x => x.Attribute("name").Value == apiName).Select(x => x.Element("key").Value).FirstOrDefault();

            return Key;
        }

        /*
         * questions.xml file structure
         * <questions>
         *  <question>
         *      <text>How would you describe your emotional connection with the immediate environment?</text>
         *      <answers>
         *          <answer key="A" primary="9" secondary="22" tertiary="23">I take time to observe and relax in the moment</answer>
         *          <answer key="B" primary="6" secondary="20" tertiary="15">I think about everything I have to do and worry</answer>
         *          <answer key="C" primary="19" secondary="3" tertiary="1">I’m interested in exploring what’s happening</answer>
         *          <answer key="D" primary="24" secondary="0" tertiary="10">I feel disconnected and prefer to isolate myself</answer>
         *      </answers>
         *  </question>
         */

        public static Questionary GetQuestionaryFromXml()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "res/questions/questions.xml");
            // Cargar el archivo XML
            var xml = XElement.Load(path);

            var questionary = new Questionary
            {
                Questions = xml.Elements("question").Select(q => new Question
                {
                    Text = q.Element("text")?.Value,
                    Options = q.Element("answers")?.Elements("answer").Select(a => new Option
                    {
                        Key = a.Attribute("key")?.Value,
                        Text = a.Value,
                        PrimaryEmotion = (EnumEmotion)int.Parse(a.Attribute("primary")?.Value ?? "0"),
                        SecondaryEmotion = (EnumEmotion)int.Parse(a.Attribute("secondary")?.Value ?? "0"),
                        TertiaryEmotion = (EnumEmotion)int.Parse(a.Attribute("tertiary")?.Value ?? "0")
                    }).ToList()
                }).ToList()
            };

            return questionary;
        }

        
        public static string GetConnectionString()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "res/SERVER_INFO/connection_string.xml");
            string connectionStringXml = System.IO.File.ReadAllText(path);

            string connectionString = XElement.Parse(connectionStringXml).Value;

            return connectionString;
        }
    }
}
