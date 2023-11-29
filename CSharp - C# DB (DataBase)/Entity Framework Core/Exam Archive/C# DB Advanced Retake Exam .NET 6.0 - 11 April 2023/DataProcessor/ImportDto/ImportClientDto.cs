using Invoices.Common;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ImportDto;

[XmlType("Client")]
public class ImportClientDto
{
    [XmlElement("Name")]
    [Required]
    [MaxLength(GlobalConstants.ClientNameMaxLength)]
    [MinLength(GlobalConstants.ClientNameMinLength)]
    public string Name { get; set; } = null!;

    [XmlElement("NumberVat")]
    [Required]
    [MaxLength(GlobalConstants.ClientNumberVatMaxLength)]
    [MinLength(GlobalConstants.ClientNumberVatMinLength)]
    public string NumberVat { get; set; } = null!;

    [XmlArray("Addresses")]
    public AddressDto[] Addresses { get; set; }
}

[XmlType("Address")]
public class AddressDto
{
    [XmlElement("StreetName")]
    [Required]
    [MinLength(GlobalConstants.AddressStreetNameMinLength)]
    [MaxLength(GlobalConstants.AddressStreetNameMaxLength)]
    public string StreetName { get; set; } = null!;

    [XmlElement("StreetNumber")]
    [Required]
    public int StreetNumber { get; set; }

    [XmlElement("PostCode")]
    [Required]
    public string PostCode { get; set; } = null!;

    [XmlElement("City")]
    [Required]
    [MinLength(GlobalConstants.AddressCityMinLength)]
    [MaxLength(GlobalConstants.AddressCityMaxLength)]
    public string City { get; set; } = null!;

    [XmlElement("Country")]
    [Required]
    [MinLength(GlobalConstants.AddressCountryMinLength)]
    [MaxLength(GlobalConstants.AddressCountryMaxLength)]
    public string Country { get; set; } = null!;
}