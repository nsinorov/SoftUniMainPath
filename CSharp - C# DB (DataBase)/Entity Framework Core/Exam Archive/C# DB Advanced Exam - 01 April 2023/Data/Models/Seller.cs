using Boardgames.Common;
using System.ComponentModel.DataAnnotations;

namespace Boardgames.Data.Models;

public class Seller
{
    //Properties
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.SellerNameMaxLength)]
    public string Name { get; set; }

    [Required]
    [MaxLength(CommonConstraints.SellerAddressMaxLength)]
    public string Address { get; set; }

    [Required]
    public string Country { get; set; }

    [Required]
    public string Website { get; set; }

    //Collections
    public virtual ICollection<BoardgameSeller> BoardgamesSellers { get; set; } = new HashSet<BoardgameSeller>();
}