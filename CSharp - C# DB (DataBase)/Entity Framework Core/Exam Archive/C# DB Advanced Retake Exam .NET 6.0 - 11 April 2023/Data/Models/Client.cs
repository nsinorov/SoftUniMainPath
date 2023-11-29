using Invoices.Common;
using System.ComponentModel.DataAnnotations;

namespace Invoices.Data.Models;

public class Client
{
    //Constructor
    public Client()
    {
        Invoices = new HashSet<Invoice>();
        Addresses= new HashSet<Address>();
        ProductsClients= new HashSet<ProductClient>();
    }

    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(GlobalConstants.ClientNameMaxLength)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(GlobalConstants.ClientNumberVatMaxLength)]
    public string NumberVat { get; set; } = null!;

    //Collections
    public virtual ICollection<Invoice> Invoices { get; set; }
    public virtual ICollection<Address> Addresses { get; set; }
    public virtual ICollection<ProductClient> ProductsClients { get; set; }
}