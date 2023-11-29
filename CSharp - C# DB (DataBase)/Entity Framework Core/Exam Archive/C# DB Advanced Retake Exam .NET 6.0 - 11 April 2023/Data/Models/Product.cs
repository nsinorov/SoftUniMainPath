using Invoices.Common;
using Invoices.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Invoices.Data.Models;

public class Product
{
    //Constructor
    public Product()
    {
        ProductsClients = new HashSet<ProductClient>();
    }

    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(GlobalConstants.ProductNameMaxLength)]
    public string Name { get; set; } = null!;

    [Required]
    [Range(GlobalConstants.ProductPriceMinRange, GlobalConstants.ProductPriceMaxRange)]
    public decimal Price { get; set; }

    [Required]
    public CategoryType CategoryType { get; set; }

    //Collections
    public ICollection<ProductClient> ProductsClients { get; set; }
}