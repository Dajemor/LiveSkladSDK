using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class Shop
{
    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}