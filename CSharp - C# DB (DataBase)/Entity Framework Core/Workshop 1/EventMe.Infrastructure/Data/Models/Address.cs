using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventMe.Infrastructure.Data.Models
{
    /// <summary>
    /// Място на провеждане на събитието
    /// </summary>
    [Comment("Място на провеждане на събитието")]
    public class Address
    {
        /// <summary>
        /// Идентификатор на мястото
        /// </summary>
        [Key]
        [Comment("Идентификатор на мястото")]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор на града
        /// </summary>
        [Required]
        [Comment("Идентификатор на града")]
        public int TownId { get; set; }

        /// <summary>
        /// Адрес на мястото
        /// </summary>
        [Required]
        [Comment("Адрес на мястото")]
        [MaxLength(100)]
        public string StreetAddress { get; set; } = null!;

        /// <summary>
        /// Град
        /// </summary>
        [Required]
        [Comment("Град")]
        [ForeignKey(nameof(TownId))]
        public Town Town { get; set; } = null!;
    }
}
