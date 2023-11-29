using Invoices.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoices.Data.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public CurrencyType CurrencyType { get; set; }

        [Required]
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }
    }
}

//•	Id – integer, Primary Key
//•	Number – integer in range  [1,000,000,000…1,500,000,000] (required)
//•	IssueDate – DateTime (required)
//•	DueDate – DateTime (required)
//•	Amount – decimal (required)
//•	CurrencyType – enumeration of type CurrencyType, with possible values (BGN, EUR, USD) (required)
//•	ClientId – integer, foreign key (required)
//•	Client – Client
