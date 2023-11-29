using Invoices.Common;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Invoices.DataProcessor.ImportDto;

public class ImportProductDto
{
    [JsonProperty("Name")]
    [Required]
    [MaxLength(GlobalConstants.ProductNameMaxLength)]
    [MinLength(GlobalConstants.ProductNameMinLength)]
    public string Name { get; set; } = null!;

    [JsonProperty("Price")]
    [Required]
    [Range(GlobalConstants.ProductPriceMinRange, GlobalConstants.ProductPriceMaxRange)]
    public decimal Price { get; set; }

    [JsonProperty("CategoryType")]
    [Required]
    [Range(GlobalConstants.ProductCategoryTypeMinRange, GlobalConstants.ProductCategoryTypeMaxRange)]
    public int CategoryType { get; set; }

    //Collections
    [JsonProperty("Clients")]
    public int[] Clients { get; set; }
}

//    "Name": "ADR light",
//    "Price": 21.25,
//    "CategoryType": 1,
//    "Clients": [
//      1,
//      85,
//      81,
//      80,
//      5,
//      9
//    ]