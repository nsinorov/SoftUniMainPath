using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;

public class PlayerStatistic
{
    public int GameId { get; set; }

    [ForeignKey(nameof(GameId))]
    public virtual Game Game { get; set; }

    public int PlayerId { get; set; }

    [ForeignKey(nameof(PlayerId))]
    public virtual Player Player { get; set; }

    public int ScoredGoals { get; set; }

    public int Assists { get; set; }

    public int MinutesPlayed { get; set; }
}