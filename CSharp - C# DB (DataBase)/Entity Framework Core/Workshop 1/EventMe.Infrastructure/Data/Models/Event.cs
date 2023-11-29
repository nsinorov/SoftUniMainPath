using EventMe.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventMe.Infrastructure.Data.Models
{
    /// <summary>
    /// Събитие
    /// </summary>
    [Comment("Събитие")]
    public class Event : IDeletable
    {
        /// <summary>
        /// Идентификатор на събитието
        /// </summary>
        [Comment("Идентификатор на събитието")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Име на събитието
        /// </summary>
        [Required]
        [Comment("Име на събитието")]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Начало на събитието
        /// </summary>
        [Required]
        [Comment("Начало на събитието")]
        public DateTime Start { get; set; }

        /// <summary>
        /// Край на събитието
        /// </summary>
        [Required]
        [Comment("Край на събитието")]
        public DateTime End { get; set; }

        /// <summary>
        /// Идентификатор на мястото
        /// </summary>
        [Required]
        [Comment("Идентификатор на мястото")]
        public int PlaceId { get; set; }

        /// <summary>
        /// Събитието е активно
        /// </summary>
        [Required]
        [Comment("Събитието е активно")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Дата на изтриване
        /// </summary>
        [Comment("Дата на изтриване")]
        public DateTime? DeletedOn { get; set; }

        /// <summary>
        /// Място на провеждане на събитието
        /// </summary>
        [Required]
        [Comment("Място на провеждане на събитието")]
        [ForeignKey(nameof(PlaceId))]
        public Address Place { get; set; } = null!;
        
    }
}
