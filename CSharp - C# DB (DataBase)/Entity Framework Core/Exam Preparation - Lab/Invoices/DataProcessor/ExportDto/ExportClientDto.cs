using System.ComponentModel.DataAnnotations;

namespace Invoices.DataProcessor.ExportDto
{
    public class ExportClientDto
    { 
        public string Name { get; set; }

        public string NumberVat { get; set; }
    }
}