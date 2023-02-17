using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class Counteragent
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rating")]
    public int Rating { get; set; }

    [JsonPropertyName("phones")]
    public List<string> Phones { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

}