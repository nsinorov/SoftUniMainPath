using Boardgames.Common;
using System.ComponentModel.DataAnnotations;

namespace Boardgames.Data.Models;

public class Creator
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.CreatorNameMaxLength)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(CommonConstraints.CreatorNameMaxLength)]
    public string LastName { get; set; }

    //Collections
    public virtual ICollection<Boardgame> Boardgames { get; set; } = new HashSet<Boardgame>();
}