using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class RootError
{
        
    [JsonPropertyName("error")]
    public Error Error { get; set; }
}