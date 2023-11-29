using Invoices.Common;
using Invoices.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoices.Data.Models;

public class Invoice
{
    //Properties
    [Key]
    public int Id { get; set; }

    [Required]
    [Range(GlobalConstants.InvoiceNumberMinRange, GlobalConstants.InvoiceNumberMaxRange)]
    public int Number { get; set; }

    [Required]
    public DateTime IssueDate { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public CurrencyType CurrencyType { get; set; }

    //Client
    [Required]
    public int ClientId { get; set; }

    [ForeignKey(nameof(ClientId))]
    public Client Client { get; set; } = null!;
}