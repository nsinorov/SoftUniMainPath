using System.ComponentModel.DataAnnotations;

namespace Invoices.Data.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MaxLength(15)]
        public string NumberVat { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; } = new HashSet<Invoice>();

        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();

        public virtual ICollection<ProductClient> ProductsClients { get; set; } = new HashSet<ProductClient>();
    }
}

//•	Id – integer, Primary Key
//•	Name – text with length [10…25] (required)
//•	NumberVat – text with length [10…15] (required)
//•	Invoices – collection of type Invoicе
//•	Addresses – collection of type Address
//•	ProductsClients – collection of type ProductClient
