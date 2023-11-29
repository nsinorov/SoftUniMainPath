using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Theatre.Common;

namespace Theatre.DataProcessor.ImportDto;

public class ImportTheatreDto
{
    [JsonProperty("Name")]
    [Required]
    [MinLength(CommonConstraints.TheatreNameMinLength)]
    [MaxLength(CommonConstraints.TheatreNameMaxLength)]
    public string Name { get; set; }

    [JsonProperty("NumberOfHalls")]
    [Required]
    [Range(CommonConstraints.TheatreHallsMinRange, CommonConstraints.TheatreHallsMaxRange)]
    public sbyte NumberOfHalls { get; set; }

    [JsonProperty("Director")]
    [Required]
    [MinLength(CommonConstraints.TheatreDirectorMinLength)]
    [MaxLength(CommonConstraints.TheatreDirectorMaxLength)]
    public string Director { get; set; }

    [JsonProperty("Tickets")]
    public ImportTicketDto[] Tickets { get; set; }
}

public class ImportTicketDto
{
    [JsonProperty("Price")]
    [Required]
    [Range(CommonConstraints.TicketPriceMinRange, CommonConstraints.TicketPriceMaxRange)]
    public decimal Price { get; set; }

    [JsonProperty("RowNumber")]
    [Required]
    [Range(CommonConstraints.TicketRowNumberMinRange, CommonConstraints.TicketRowNumberMaxRange)]
    public sbyte RowNumber { get; set; }

    [JsonProperty("PlayId")]
    [Required]
    public int PlayId { get; set; }
}