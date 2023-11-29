using Boardgames.Common;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Boardgames.DataProcessor.ImportDto;

public class ImportSellerDto
{
    [JsonProperty("Name")]
    [Required]
    [MinLength(CommonConstraints.SellerNameMinLength)]
    [MaxLength(CommonConstraints.SellerNameMaxLength)]
    public string Name { get; set; } = null!;

    [JsonProperty("Address")]
    [Required]
    [MinLength(CommonConstraints.SellerAddressMinLength)]
    [MaxLength(CommonConstraints.SellerAddressMaxLength)]
    public string Address { get; set; } = null!;

    [JsonProperty("Country")]
    [Required]
    public string Country { get; set; } = null!;

    [JsonProperty("Website")]
    [Required]
    [RegularExpression(CommonConstraints.SellerWebsiteRegex)]
    public string Website { get; set; } = null!;

    //Collections
    [JsonProperty("Boardgames")]
    public int[] BoardgamesIds { get; set; } = null!;
}