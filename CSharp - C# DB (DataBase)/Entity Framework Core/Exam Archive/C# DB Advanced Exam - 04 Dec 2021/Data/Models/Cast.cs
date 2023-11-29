using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Theatre.Common;

namespace Theatre.Data.Models;

public class Cast
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(CommonConstraints.CastFullNameMaxLength)]
    public string FullName { get; set; }

    [Required]
    public bool IsMainCharacter { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    //Play
    [Required]
    public int PlayId { get; set; }

    [ForeignKey(nameof(PlayId))]
    public Play Play { get; set; }
}