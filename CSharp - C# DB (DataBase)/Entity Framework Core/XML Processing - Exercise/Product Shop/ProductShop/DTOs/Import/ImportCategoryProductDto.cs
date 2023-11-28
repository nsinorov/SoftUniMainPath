using ProductShop.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Import;

[XmlType("CategoryProduct")]
public class ImportCategoryProductDto
{
    [XmlElement("CategoryId")]
    public int CategoryId { get; set; }

    [XmlElement("ProductId")]
    public int ProductId { get; set; }
}