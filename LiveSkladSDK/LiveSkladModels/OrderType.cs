using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class OrderType
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }
}