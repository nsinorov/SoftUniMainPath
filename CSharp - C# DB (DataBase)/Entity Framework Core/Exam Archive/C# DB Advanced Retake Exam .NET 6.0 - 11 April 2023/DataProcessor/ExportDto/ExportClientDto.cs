using Invoices.Data.Enums;
using System.Globalization;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ExportDto;

[XmlType("Client")]
public class ExportClientDto
{
    [XmlAttribute("InvoicesCount")]
    public int InvoicesCount { get; set; }

    [XmlElement("ClientName")]
    public string ClientName { get; set; } = null!;

    [XmlElement("VatNumber")]
    public string VatNumber { get; set; } = null!;

    [XmlArray("Invoices")]
    public ExportInvoiceDto[] Invoices { get; set; }
}

[XmlType("Invoice")]
public class ExportInvoiceDto
{
    [XmlElement("InvoiceNumber")]
    public int InvoiceNumber { get; set; }

    [XmlElement("InvoiceAmount")]
    public decimal InvoiceAmount { get; set; }

    [XmlElement("DueDate")]
    public string DueDate { get; set; } = null!;

    [XmlElement("Currency")]
    public string Currency { get; set; }
}