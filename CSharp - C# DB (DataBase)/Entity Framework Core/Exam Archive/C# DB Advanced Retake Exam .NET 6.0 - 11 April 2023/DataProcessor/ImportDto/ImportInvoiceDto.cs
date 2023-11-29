using Invoices.Common;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Invoices.DataProcessor.ImportDto;

public class ImportInvoiceDto
{
    [JsonProperty("Number")]
    [Required]
    [Range(GlobalConstants.InvoiceNumberMinRange, GlobalConstants.InvoiceNumberMaxRange)]
    public int Number { get; set; }

    [JsonProperty("IssueDate")]
    [Required]
    public string IssueDate { get; set; } = null!;

    [JsonProperty("DueDate")]
    [Required]
    public string DueDate { get; set; } = null!;

    [JsonProperty("Amount")]
    [Required]
    public decimal Amount { get; set; }

    [JsonProperty("CurrencyType")]
    [Required]
    [Range(GlobalConstants.InvoiceCurrencyTypeMinRange, GlobalConstants.InvoiceCurrencyTypeMaxRange)]
    public int CurrencyType { get; set; }

    [JsonProperty("ClientId")]
    [Required]
    public int ClientId { get; set; }
}