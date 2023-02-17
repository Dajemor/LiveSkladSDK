using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class SingleRoot<T>
{
    [JsonPropertyName("data")]
    public T Data { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("remainRequest")]
    public int RemainRequest { get; set; }
}