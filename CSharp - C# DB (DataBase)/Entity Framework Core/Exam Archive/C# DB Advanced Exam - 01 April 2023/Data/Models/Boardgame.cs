using Boardgames.Common;
using Boardgames.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boardgames.Data.Models;

public class Boardgame
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.BoardgameNameMaxLength)]
    public string Name { get; set; }

    [Required]
    [Range(CommonConstraints.BoardgameRatingMinRange, CommonConstraints.BoardgameRatingMaxRange)]
    public double Rating { get; set; }

    [Required]
    [Range(CommonConstraints.BoardgameYearPublishedMinRange, CommonConstraints.BoardgameYearPublishedMaxRange)]
    public int YearPublished { get; set; }

    [Required]
    public CategoryType CategoryType { get; set; }

    [Required]
    public string Mechanics { get; set; }

    //Creator
    [Required]
    public int CreatorId { get; set; }

    [ForeignKey(nameof(CreatorId))]
    public Creator Creator { get; set; }

    //Collections
    public virtual ICollection<BoardgameSeller> BoardgamesSellers { get; set; } = new HashSet<BoardgameSeller>();
}