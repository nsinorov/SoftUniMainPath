using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Invoices.Common;

namespace Invoices.Data.Models;

public class Address
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(GlobalConstants.AddressStreetNameMaxLength)]
    public string StreetName { get; set; } = null!;

    [Required]
    public int StreetNumber { get; set; }

    [Required]
    public string PostCode { get; set; } = null!;

    [Required]
    [MaxLength(GlobalConstants.AddressCityMaxLength)]
    public string City { get; set; } = null!;

    [Required]
    [MaxLength(GlobalConstants.AddressCountryMaxLength)]
    public string Country { get; set; } = null!;

    //Client
    [Required]
    public int ClientId { get; set; }

    [ForeignKey(nameof(ClientId))]
    public Client Client { get; set; } = null!;
}