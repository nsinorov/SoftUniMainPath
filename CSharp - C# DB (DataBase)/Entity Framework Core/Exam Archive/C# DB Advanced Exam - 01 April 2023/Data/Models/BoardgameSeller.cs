using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Boardgames.Data.Models;

public class BoardgameSeller
{
    //Boardgame
    [Required]
    public int BoardgameId { get; set; }

    [ForeignKey(nameof(BoardgameId))]
    public Boardgame Boardgame { get; set; }

    //Seller
    [Required]
    public int SellerId { get; set; }

    [ForeignKey(nameof(SellerId))]
    public Seller Seller { get; set; }
}