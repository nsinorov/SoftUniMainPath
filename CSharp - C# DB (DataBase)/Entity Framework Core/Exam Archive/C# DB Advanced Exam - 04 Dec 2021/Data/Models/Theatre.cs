using System.ComponentModel.DataAnnotations;
using Theatre.Common;

namespace Theatre.Data.Models;

public class Theatre
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.TheatreNameMaxLength)]
    public string Name { get; set; }

    [Required]
    [Range(CommonConstraints.TheatreHallsMinRange, CommonConstraints.TheatreHallsMaxRange)]
    public sbyte NumberOfHalls { get; set; }

    [Required]
    [MaxLength(CommonConstraints.TheatreDirectorMaxLength)]
    public string Director { get; set; }

    //Collections
    public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
}