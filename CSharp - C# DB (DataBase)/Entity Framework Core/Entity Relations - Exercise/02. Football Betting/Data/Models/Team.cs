using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;

public class Team
{
    public Team()
    {
        Players = new HashSet<Player>();
    }

    [Key]
    public int TeamId { get; set; }

    [Required]
    public string Name { get; set; }

    public string LogoUrl { get; set; }

    [MaxLength(3)]
    public string Initials { get; set; }

    [Required]
    public decimal Budget { get; set; }


    public int PrimaryKitColorId { get; set; }

    [ForeignKey(nameof(PrimaryKitColorId))]
    public Color PrimaryKitColor { get; set; }


    public int SecondaryKitColorId { get; set; }

    [ForeignKey(nameof(SecondaryKitColorId))]
    public Color SecondaryKitColor { get; set; }


    public int TownId { get; set; }

    [ForeignKey(nameof(TownId))]
    public Town Town { get; set; }


    [InverseProperty(nameof(Game.HomeTeam))]
    public virtual ICollection<Game> HomeGames { get; set; }

    [InverseProperty(nameof(Game.AwayTeam))]
    public virtual ICollection<Game> AwayGames { get; set; }

    public virtual ICollection<Player> Players { get; set; }
}