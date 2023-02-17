using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class HowKnow
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}