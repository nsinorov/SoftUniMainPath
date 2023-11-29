using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ImportDto
{
    [XmlType("Address")]
    public class ImportAddressDto
    {

        [Required]
        [MaxLength(20)]
        [MinLength(10)]
        public string StreetName { get; set; }

        [Required]
        public int StreetNumber { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(5)]
        public string City { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(5)]
        public string Country { get; set; }
    }

    //•	StreetName – text with length [10…20] (required)
    //•	StreetNumber – integer (required)
    //•	PostCode – text (required)
    //•	City – text with length [5…15] (required)
    //•	Country – text with length [5…15] (required)
}
