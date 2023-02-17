using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class SuccessModel
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}