using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSkladSDK.RequestModel
{
    public class OrderFilter
    {
        /// <summary>
        /// Номер страницы выборки ( по умолчанию - 1)
        /// </summary>
        public int? page { get; set; }
        /// <summary>
        /// Количество элементов в выборке (по умолчанию - 10, максимум - 50)
        /// </summary>
        public int? pageSize { get; set; }
        /// <summary>
        /// Фильтр по удаленным заказам. Если true - будут считаны только не удаленные заказы, если false - будут считаны только удаленные заказы, если параметр не отсутствует - будут считаны все заказы
        /// </summary>
        public bool? isVisible { get; set; }
        /// <summary>
        /// Сортировка
        /// </summary>
        public string? sort { get; set; }
        /// <summary>
        /// Фильтр по статусам заказов, передается в виде массива id статусов
        /// </summary>
        public string[]? statusIds {get; set;}
        /// <summary>
        /// Фильтр по мастеру которому назначен заказ
        /// </summary>
        public string? masterId { get; set; }
        /// <summary>
        /// Фильтр по менеджеру которому назначен заказ
        /// </summary>
        public string? managerId { get; set; }
        /// <summary>
        /// Фильтр по контрагенту
        /// </summary>
        public string? counteragentId { get; set; }
        /// <summary>
        /// Фильтр: "Срочные заказы"
        /// </summary>
        public bool? isUrgent { get; set; }
        /// <summary>
        /// Фильтр: "Просроченные заказы"
        /// </summary>
        public bool? isDeadline { get; set; }
        /// <summary>
        /// Фильтр: "Просроченные по норме времени статуса"
        /// </summary>
        public bool? isStatusDeadline { get; set; }
        /// <summary>
        /// Текст для поиска по содержимому заказа
        /// </summary>
        public string? filter { get; set; }
        /// <summary>
        /// Номер заказа (текстовый номер, ищет по частичному совпадению номера заказа с учетом префикса)
        /// </summary>
        public string? numer { get; set; }
        /// <summary>
        /// Номер заказа (числовой номер, ищет по точному соответствию номера заказа без учета префикса)
        /// </summary>
        public int? num { get; set; }
        /// <summary>
        /// Начальная дата для поиска заказов
        /// </summary>
        public double? dateFrom { get; set; }
        /// <summary>
        /// Конечная дата для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? dateTo { get; set; }
        /// <summary>
        /// Начальная дата создания для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? dateCreateFrom { get; set; }
        /// <summary>
        /// Конечная дата создания для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? dateCreateTo { get; set; }
        /// <summary>
        /// Начальная дата готовности для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? dateFinishFrom { get; set; }
        /// <summary>
        /// Конечная дата готовности для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? dateFinishTo { get; set; }
        /// <summary>
        /// Начальная дата выдачи для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? dateCloseFrom { get; set; }
        /// <summary>
        /// Конечная дата выдачи для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? dateCloseTo { get; set; }
        /// <summary>
        /// Начальная дата крайнего срока для поиска заказов  передается в формате Unix, в миллисекундах
        /// </summary>
        public double? deadlineFrom { get; set; }
        /// <summary>
        /// Конечная дата крайнего срока для поиска заказов  передается в формате Unix, в миллисекундах
        /// </summary>
        public double? deadlineTo { get; set; }
        /// <summary>
        /// Начальная дата крайнего срока статуса для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? statusDeadlineFrom { get; set; }
        /// <summary>
        /// Конечная дата крайнего срока статуса для поиска заказов передается в формате Unix, в миллисекундах
        /// </summary>
        public double? statusDeadlineTo { get; set; }
        /// <summary>
        /// Начальная дата последнего изменения для поиска заказов  передается в формате Unix, в миллисекундах
        /// </summary>
        public double? lastActionFrom { get; set; }
        /// <summary>
        /// Конечная дата последнего изменения для поиска заказов  передается в формате Unix, в миллисекундах
        /// </summary>
        public double? lastActionTo { get; set; }
    }
}










