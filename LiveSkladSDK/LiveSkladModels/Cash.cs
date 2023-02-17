using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class Cash
{
    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("orderPrepayment")]
    public int OrderPrepayment { get; set; }

    [JsonPropertyName("orderReturn")]
    public int OrderReturn { get; set; }

    [JsonPropertyName("invoice")]
    public int Invoice { get; set; }
}