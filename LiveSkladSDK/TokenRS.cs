using System.Text.Json.Serialization;

namespace LiveSkladSDK
{
    public class TokenRS
    {
        
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("ttl")]
        public int Ttl { get; set; }

        [JsonPropertyName("remainRequest")]
        public int RemainRequest { get; set; }
    }
}