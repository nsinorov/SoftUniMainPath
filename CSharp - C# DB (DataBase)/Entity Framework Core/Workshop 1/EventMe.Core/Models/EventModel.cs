using EventMe.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace EventMe.Core.Models
{
    public class EventModel
    {
        /// <summary>
        /// Идентификатор на събитието
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Име на събитието
        /// </summary>
        [Required(ErrorMessage = UserMessageConstants.Required)]
        [Display(Name = "Име на събитието")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = UserMessageConstants.StringLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Начало на събитието
        /// </summary>
        [Required(ErrorMessage = UserMessageConstants.Required)]
        [Display(Name = "Начало на събитието")]
        public DateTime Start { get; set; }

        /// <summary>
        /// Край на събитието
        /// </summary>
        [Required(ErrorMessage = UserMessageConstants.Required)]
        [Display(Name = "Край на събитието")]
        public DateTime End { get; set; }

        /// <summary>
        /// Mясто на провеждане
        /// </summary>
        [Required(ErrorMessage = UserMessageConstants.Required)]
        [Display(Name = "Място на провеждане")]
        public string StreetAddress { get; set; } = "";

        /// <summary>
        /// Град
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = UserMessageConstants.Required)]
        [Display(Name = "Град")]
        public int TownId { get; set; }

        /// <summary>
        /// Име на града
        /// </summary>
        [Display(Name = "Град")]
        public string TownName { get; set; } = "";
    }
}
