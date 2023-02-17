using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels
{
    public class LSRoot<T> where T : class
    {
        [JsonPropertyName("data")]
        public List<T> Data { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("remainRequest")]
        public int RemainRequest { get; set; }
    }

    public class Ids
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
