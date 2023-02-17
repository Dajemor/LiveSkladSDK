using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveSkladSDK.LiveSkladModels
{
    public class SingleOrder
    {
        [JsonPropertyName("dateCreate")]
        public DateTime DateCreate { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("num")]
        public int Num { get; set; }

        [JsonPropertyName("counteragentId")]
        public string CounteragentId { get; set; }

        [JsonPropertyName("createManagerId")]
        public string CreateManagerId { get; set; }

        [JsonPropertyName("typeOrderId")]
        public string TypeOrderId { get; set; }

        [JsonPropertyName("isVisible")]
        public bool IsVisible { get; set; }

        [JsonPropertyName("isUrgent")]
        public bool IsUrgent { get; set; }

        [JsonPropertyName("statusId")]
        public string StatusId { get; set; }

        [JsonPropertyName("typeStatus")]
        public int TypeStatus { get; set; }

        [JsonPropertyName("lastAction")]
        public DateTime LastAction { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("problem")]
        public List<string> Problem { get; set; }

        [JsonPropertyName("prepayment")]
        public int Prepayment { get; set; }

        [JsonPropertyName("approximatePrice")]
        public string ApproximatePrice { get; set; }

        [JsonPropertyName("node")]
        public string Node { get; set; }

        [JsonPropertyName("customFields")]
        public List<object> CustomFields { get; set; }

        [JsonPropertyName("summ")]
        public Summ Summ { get; set; }

        [JsonPropertyName("shopId")]
        public string ShopId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("shop")]
        public Shop Shop { get; set; }

        [JsonPropertyName("typeOrder")]
        public string TypeOrder { get; set; }

        [JsonPropertyName("cash")]
        public Cash Cash { get; set; }

        [JsonPropertyName("howKnow")]
        public HowKnow HowKnow { get; set; }

        [JsonPropertyName("counteragent")]
        public Counteragent Counteragent { get; set; }

        [JsonPropertyName("isChange")]
        public bool IsChange { get; set; }

        [JsonPropertyName("isChecked")]
        public bool IsChecked { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("isMyself")]
        public bool IsMyself { get; set; }

        [JsonPropertyName("workProducts")]
        public List<object> WorkProducts { get; set; }
    }
}
