using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveSkladSDK.LiveSkladModels
{
    public class TypeCounteragents
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("sort")]
        public int Sort { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
