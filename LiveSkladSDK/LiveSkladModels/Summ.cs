using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class Summ
{/// <summary>
/// price - сумма по заказу с учетом скидки (цена работ + цена запчастей)
/// </summary>
    [JsonPropertyName("price")]
    public double Price { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
    /// <summary>
    /// orderPrice - сумма по заказу без учета скидки(цена работ + цена запчастей)
    /// </summary>
    [JsonPropertyName("orderPrice")]
    public double OrderPrice { get; set; }
    /// <summary>
    /// purchasePrice - себестоимость заказа(себестоимость работ + себестоимость запчастей)
    /// </summary>
    [JsonPropertyName("purchasePrice")]
    public double PurchasePrice { get; set; }
  
}