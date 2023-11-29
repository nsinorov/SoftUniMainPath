using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Trucks.Common;

namespace Trucks.DataProcessor.ImportDto;

public class ImportClientDto
{
    [JsonProperty("Name")]
    [Required]
    [MinLength(CommonConstraints.ClientNameMinLength)]
    [MaxLength(CommonConstraints.ClientNameMaxLength)]
    public string Name { get; set; }

    [JsonProperty("Nationality")]
    [Required]
    [MinLength(CommonConstraints.ClientNationalityMinLength)]
    [MaxLength(CommonConstraints.ClientNationalityMaxLength)]
    public string Nationality { get; set; }

    [JsonProperty("Type")]
    [Required]
    public string Type { get; set; }

    [JsonProperty("Trucks")]
    public int[] TrucksIds { get; set; }
}