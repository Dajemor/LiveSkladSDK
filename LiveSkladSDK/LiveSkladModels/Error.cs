using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveSkladSDK.LiveSkladModels
{
    public class Error
    {
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("remainRequest")]
        public int RemainRequest { get; set; }
    }
    public class ErrorRoot
    {
        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }
}
