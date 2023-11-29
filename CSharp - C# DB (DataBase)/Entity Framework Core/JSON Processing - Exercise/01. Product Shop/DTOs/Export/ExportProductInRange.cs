using Newtonsoft.Json;

namespace ProductShop.DTOs.Export;

public class ExportProductInRange
{
    [JsonProperty("name")]
    public string ProductName { get; set; } = null!;

    [JsonProperty("price")]
    public decimal ProductPrice { get; set; }

    [JsonProperty("seller")]
    public string SellerName { get; set; } = null!;
}