using System.Text.Json.Serialization;

namespace LiveSkladSDK
{
    public class LoginData
    {
        [JsonPropertyName("login")]
        public string login { get; set; }

        [JsonPropertyName("password")]
        public string password { get; set; }
    
    }
}