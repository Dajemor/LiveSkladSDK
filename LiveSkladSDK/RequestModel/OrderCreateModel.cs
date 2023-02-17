using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveSkladSDK.RequestModel
{
    
    public class OrderCreateModel
    {
        /// <summary>
        /// id контрагента
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? counteragentId { get; set; }
        /// <summary>
        /// Имя контрагента
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? name { get; set; }
        /// <summary>
        /// Адрес контрагента
        /// </summary>
        public string? address { get; set; }
        /// <summary>
        /// Телефоны контрагента, передаются в виде массива строк
        /// </summary>
        public string[]? phones { get; set; }
        /// <summary>
        /// email контрагента
        /// </summary>
        public string? email { get; set; }
        /// <summary>
        /// Контрагент является покупателем (по умолчанию - false)
        /// </summary>
        public bool? isBuyer { get; set; }
        /// <summary>
        /// Контрагент является поставщиком (по умолчанию - false)
        /// </summary>
        public bool? isVendor { get; set; } 
        /// <summary>
        /// Примечание контрагента
        /// </summary>
        public string? counteragentNode { get; set; }
        /// <summary>
        /// Контрагенту можно отправлять смс-сообщения (по умолчанию - false)
        /// </summary>
        public bool? isSendSms { get; set; }
        /// <summary>
        /// Рейтинг контрагента (обычный: 0, негативный клиент: -1, позитивный: 1)
        /// </summary>
        public int? rating { get; set; }
        /// <summary>
        /// id типа заказа
        /// </summary>
        public string? typeOrderId { get; set; }
        /// <summary>
        /// Срочный заказ (по умолчанию - false)
        /// </summary>
        public bool? isUrgent { get; set; }
        /// <summary>
        /// id мастера которому необходимо назначить заказ
        /// </summary>
        public string? masterId { get; set; }
        /// <summary>
        ///  id менеджера которому необходимо назначить заказ
        /// </summary>
        public string? managerId { get; set; }
        /// <summary>
        /// Крайний срок заказа (передается в формате Unix, в миллисекундах)
        /// </summary>
        public long? deadline { get; set; }
        /// <summary>
        ///  Тип устройства
        /// </summary>
        public string? typeDevice { get; set; }
        /// <summary>
        /// Марка
        /// </summary>
        public string? brand { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        public string? model { get; set; }
        /// <summary>
        ///     Серийный номер
        /// </summary>
        public string? sn { get; set; }
        /// <summary>
        /// Список неисправностей, передается в виде массива строк
        /// </summary>
        public string[]? problem { get; set; }
        /// <summary>
        /// Комплектация, передается в виде массива строк
        /// </summary>
        public string[]? completeSet { get; set; }
        /// <summary>
        ///  id кассы в которую будет принята предоплата
        /// </summary>
        public string? cashRegisterId { get; set; }
        /// <summary>
        /// Сумма предоплаты наличными
        /// </summary>
        public int? prepaymentMoney { get; set; }
        /// <summary>
        /// Сума предоплаты безналичными
        /// </summary>
        public int? prepaymentBank { get; set; }
        /// <summary>
        /// Предварительная стоимость
        /// </summary>
        public string? approximatePrice { get; set; }
        /// <summary>
        /// Примечание к заказу
        /// </summary>
        public string? orderNode { get; set; }
        /// <summary>
        /// Внешний вид, передается в виде массива строк
       /// </summary>
        public string[]? appearance { get; set; }
        /// <summary>
        /// Цвет
        /// </summary>
        public string? color { get; set; }
        /// <summary>
        /// Массив пользовательских полей
        /// </summary>
        public customFields[]? customFields { get; set; }

    }
}
