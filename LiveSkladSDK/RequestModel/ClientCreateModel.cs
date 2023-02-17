using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveSkladSDK.RequestModel
{
    
    public class ClientCreateModel
    {
        /// <summary>
        /// Имя контрагента
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// id типа контрагента
        /// </summary>
        public string typeCounteragentId { get; set; }

        /// <summary>
        /// Контрагент является покупателем
        /// </summary>
        public bool isBuyer { get; set; } = true;
        /// <summary>
        /// Контрагент является поставщиком
        /// </summary>
        public bool isVendor { get; set; } = false;
        /// <summary>
        /// email контрагента
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? email { get; set; }
        /// <summary>
        /// id источника рекламы контрагента
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? howKnowId { get; set; }
        /// <summary>
        /// Адрес контрагента
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? address { get; set; }
        /// <summary>
        /// Телефоны контрагента, передается в виде массива строк
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string[]? phones { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? node { get; set; }
        /// <summary>
        /// Контрагенту можно отправлять смс-сообщения(по умолчанию - false)
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? isSendSms { get; set; }
        /// <summary>
        /// Рейтинг контрагента(обычный: 0, негативный клиент: -1, позитивный: 1)
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? rating { get; set; }
        /// <summary>
        /// Массив пользовательских полей
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public customFields[]? customFields { get; set; }
    }
    
   
    
    
    
    
    // number
    //Р
    //customFields array
    //
}
