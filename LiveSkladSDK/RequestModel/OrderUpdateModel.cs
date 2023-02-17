using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSkladSDK.RequestModel
{
    public class OrderUpdateModel
    {
        /// <summary>
        /// id источника рекламы(изменяет источник рекламы заказа)
        /// </summary>
        public string? howKnowId { get; set; }
        /// <summary>
        /// id статуса
        /// </summary>
        public string? statusId { get; set;}
        /// <summary>
        /// id типа заказа
        /// </summary>
        public string? typeOrderId { get; set;}
        /// <summary>
        /// Срочный заказ
        /// </summary>
        public bool? isUrgent { get; set;}
        /// <summary>
        /// id менеджера которому необходимо назначить заказ
        /// </summary>
        public string? managerId { get; set;}
        /// <summary>
        /// id мастера которому необходимо назначить заказ
        /// </summary>
        public string? masterId { get; set;}
        /// <summary>
        /// Крайний срок
        /// </summary>
        public long? deadline { get; set;}
        /// <summary>
        /// Тип устройства
        /// </summary>
        public string? typeDevice { get; set;}
        /// <summary>
        /// Марка
        /// </summary>
        public string? brand { get; set;}
        /// <summary>
        /// Модель
        /// </summary>
        public string? model { get; set;}
        /// <summary>
        /// Серийный номер
        /// </summary>
        public string? sn { get; set;}
        /// <summary>
        /// Список неисправностей, передается в виде массива строк
        /// </summary>
        public string[]? problem { get; set;}
        /// <summary>
        /// Комплектация, передается в виде массива строк
        /// </summary>
        public string[]? completeSet { get; set;}
        /// <summary>
        /// Предварительная стоимость
        /// </summary>
        public string? approximatePrice { get; set;}
        /// <summary>
        /// Примечание к заказу
        /// </summary>
        public string? orderNode { get; set;}
        /// <summary>
        /// Внешний вид, передается в виде массива строк
        /// </summary>
        public string[]? appearance { get; set;}
        /// <summary>
        /// id кассы в которую будет принята оплата
        /// </summary>
        public string[]? cashRegisterId { get; set;}
        /// <summary>
        /// Сумма наличными
        /// </summary>
        public int? money { get; set;}
        /// <summary>
        /// Сумма безналичными
        /// </summary>
        public int? bank { get; set;}
        /// <summary>
        /// Примечание к оплате
        /// </summary>
        public string? nodePay { get; set;}
        /// <summary>
        /// Цвет
        /// </summary>
        public string? color { get; set;}
        /// <summary>
        /// Вердикт / рекомендации
        /// </summary>
        public string? recommendation { get; set;}
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? comment { get; set;}
        /// <summary>
        /// Массив пользовательских полей
        /// </summary>
        public customFields? customFields { get; set;}




    }
  
}
