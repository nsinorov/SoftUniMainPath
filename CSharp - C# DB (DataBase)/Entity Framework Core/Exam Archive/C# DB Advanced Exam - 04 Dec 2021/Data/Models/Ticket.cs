using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Theatre.Common;

namespace Theatre.Data.Models;

public class Ticket
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [Range(CommonConstraints.TicketPriceMinRange, CommonConstraints.TicketPriceMaxRange)]
    public decimal Price { get; set; }

    [Required]
    [Range(CommonConstraints.TicketRowNumberMinRange, CommonConstraints.TicketRowNumberMaxRange)]
    public sbyte RowNumber { get; set; }

    //Play
    [Required]
    public int PlayId { get; set; }

    [ForeignKey(nameof(PlayId))]
    public Play Play { get; set; }

    //Theatre
    [Required]
    public int TheatreId { get; set; }

    [ForeignKey(nameof(TheatreId))]
    public Theatre Theatre { get; set; }
}