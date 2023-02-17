using System.Text.Json.Serialization;

namespace LiveSkladSDK.RequestModel
{
    public class customFields
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("value")]
        public object Value { get; set; }
    }
}