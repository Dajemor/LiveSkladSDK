using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSkladSDK.RequestModel
{
    public class ClientFilter
    {
        /// <summary>
        /// Телефон для поиска
        /// </summary>
        public string? phone { get; set; }
        /// <summary>
        /// Номер страницы выборки(по умолчанию - 1)
        /// </summary>
        public int? page { get; set; }
        /// <summary>
        /// Количество элементов в выборке(по умолчанию - 10, максимум - 50)
        /// </summary>
        public int? pageSize { get; set; }
        /// <summary>
        /// Фильтр даты создания контрагента
        /// </summary>
        public long? dateCreateFrom { get; set; }
        /// <summary>
        /// Фильтр даты создания контрагента
        /// </summary>
        public long? dateCreateTo { get; set; }
        /// <summary>
        /// Сортировка
        /// </summary>
        public string? sort { get; set; }
        /// <summary>
        /// Текст для поиска по контрагентам
        /// </summary>
        public string? filter { get; set; }
        /// <summary>
        /// Фильтр даты последнего изменения контрагента
        /// </summary>
        public long? lastActionFrom { get; set; }
        /// <summary>
        /// Фильтр даты последнего изменения контрагента
        /// </summary>
        public long? lastActionTo { get; set; }
        /// <summary>
        /// Фильтр: "Только покупатели"
        /// </summary>
        public bool? isBuyer { get; set; }
        /// <summary>
        /// Фильтр: "Только поставщики"
        /// </summary>
        public bool? isVendor { get; set; }
        /// <summary>
        /// Фильтр по источникам рекламы, передается в виде массива id источников рекламы
        /// </summary>
        public string[]? howKnowIds { get; set; }
        /// <summary>
        /// Фильтр по типу контрагента
        /// </summary>
        public string[]? typeCounteragentId { get; set; }
        
    }
}
