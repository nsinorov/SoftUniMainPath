using Footballers.Common;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Footballers.DataProcessor.ImportDto;

public class ImportTeamDto
{
    [JsonProperty("Name")]
    [Required]
    [RegularExpression(CommonConstraints.TeamNameRegex)]
    public string Name { get; set; }

    [JsonProperty("Nationality")]
    [Required]
    [MinLength(CommonConstraints.TeamNationalityMinLength)]
    [MaxLength(CommonConstraints.TeamNationalityMaxLength)]
    public string Nationality { get; set; }

    [JsonProperty("Trophies")]
    [Required]
    public int Trophies { get; set; }

    //Collections
    [JsonProperty("Footballers")]
    public int[] FootballersIds { get; set; }
}