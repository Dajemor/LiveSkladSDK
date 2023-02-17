using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels
{
    public class LSOrders
    {
        [JsonPropertyName("isUrgent")]
        public bool? IsUrgent { get; set; }

        [JsonPropertyName("shop")]
        public Shop Shop { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        //[JsonPropertyName("customFields")]
        //public CustomFields CustomFields { get; set; }

        [JsonPropertyName("num")]
        public int Num { get; set; }

        [JsonPropertyName("closeManager")]
        public string CloseManager { get; set; }

        [JsonPropertyName("counteragent")]
        public Counteragent Counteragent { get; set; }

        [JsonPropertyName("dateFinish")]
        public DateTime DateFinish { get; set; }

        [JsonPropertyName("typeOrderId")]
        public string TypeOrderId { get; set; }

        [JsonPropertyName("dateCreate")]
        public DateTime DateCreate { get; set; }

        [JsonPropertyName("prepayment")]
        public int Prepayment { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("problem")]
        public List<string> Problem { get; set; }

        [JsonPropertyName("completeSet")]
        public List<string> CompleteSet { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("shopId")]
        public string ShopId { get; set; }

        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }
        /// <summary>
        ///   cash - сумма внесенных по заказу денег  
        /// </summary>
        [JsonPropertyName("cash")]
        public double Cash { get; set; }

        [JsonPropertyName("counteragentId")]
        public string CounteragentId { get; set; }

        [JsonPropertyName("images")]
        public List<object> Images { get; set; }

        [JsonPropertyName("createManagerId")]
        public string CreateManagerId { get; set; }

        [JsonPropertyName("manager")]
        public string Manager { get; set; }

        [JsonPropertyName("typeOrder")]
        public string TypeOrder { get; set; }

        [JsonPropertyName("typeStatus")]
        public int TypeStatus { get; set; }
        /// <summary>
        ///   approximatePrice - поле "Ориентировочная цена"
        /// </summary>
        [JsonPropertyName("approximatePrice")]
        public string ApproximatePrice { get; set; }

        [JsonPropertyName("isVisible")]
        public bool IsVisible { get; set; }

        [JsonPropertyName("managerId")]
        public string ManagerId { get; set; }

        [JsonPropertyName("closeManagerId")]
        public string CloseManagerId { get; set; }

        [JsonPropertyName("master")]
        public string Master { get; set; }

        [JsonPropertyName("masterId")]
        public string MasterId { get; set; }

        [JsonPropertyName("appearance")]
        public List<string> Appearance { get; set; }

        [JsonPropertyName("statusId")]
        public string StatusId { get; set; }

        [JsonPropertyName("summ")]
        public Summ Summ { get; set; }

        [JsonPropertyName("dateClose")]
        public DateTime DateClose { get; set; }

        [JsonPropertyName("typeDevice")]
        public string TypeDevice { get; set; }

        [JsonPropertyName("device")]
        public string Device { get; set; }

        [JsonPropertyName("giveShop")]
        public GiveShop GiveShop { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("isChange")]
        public bool IsChange { get; set; }

        [JsonPropertyName("isMyself")]
        public bool IsMyself { get; set; }

        [JsonPropertyName("howKnowId")]
        public string HowKnowId { get; set; }

        [JsonPropertyName("node")]
        public string Node { get; set; }
        
        
    }
}
