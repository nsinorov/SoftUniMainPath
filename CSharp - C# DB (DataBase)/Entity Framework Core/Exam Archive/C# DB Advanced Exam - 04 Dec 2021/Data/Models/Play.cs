using System.ComponentModel.DataAnnotations;
using Theatre.Common;
using Theatre.Data.Enums;

namespace Theatre.Data.Models;

public class Play
{
    //Properties
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.PlayTitleMaxLength)]
    public string Title { get; set; }

    [Required]
    public TimeSpan Duration { get; set; }

    [Required]
    [Range(CommonConstraints.PlayRatingMinRange, CommonConstraints.PlayRatingMaxRange)]
    public float Rating { get; set; }

    [Required]
    public Genre Genre { get; set; }

    [Required]
    [MaxLength(CommonConstraints.PlayDescriptionMaxLength)]
    public string Description { get; set; }

    [Required]
    [MaxLength(CommonConstraints.PlayScreenwriterMaxLength)]
    public string Screenwriter { get; set; }

    //Collections
    public ICollection<Cast> Casts { get; set; } = new HashSet<Cast>();
    public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
}