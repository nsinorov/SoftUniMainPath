namespace Invoices.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Invoices.Data;
    using Invoices.Data.Models;
    using Invoices.DataProcessor.ImportDto;
    using Invoices.Extensions;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedClients
            = "Successfully imported client {0}.";

        private const string SuccessfullyImportedInvoices
            = "Successfully imported invoice with number {0}.";

        private const string SuccessfullyImportedProducts
            = "Successfully imported product - {0} with {1} clients.";


        public static string ImportClients(InvoicesContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            List<ImportClientDto> clientsDto = xmlString
                .DeserializeFromXml<List<ImportClientDto>>("Clients");

            List<Client> clients = new List<Client>();

            foreach (var client in clientsDto)
            {
                if (!IsValid(client))
                {
                    sb.AppendLine(ErrorMessage);

                    continue;
                }

                var clientToAdd = new Client
                {
                    Name = client.Name,
                    NumberVat = client.NumberVat
                };

                foreach (var address in client.Addresses)
                {
                    if (IsValid(address))
                    {
                        clientToAdd.Addresses.Add(new Address()
                        {
                            City = address.City,
                            Country = address.Country,
                            PostCode = address.PostCode,
                            StreetName = address.StreetName,
                            StreetNumber = address.StreetNumber
                        });
                    }
                    else
                    {
                        sb.AppendLine(ErrorMessage);
                    }
                }

                clients.Add(clientToAdd);
                sb.AppendLine(string.Format(SuccessfullyImportedClients, client.Name));
            }

            context.Clients.AddRange(clients);
            context.SaveChanges();

            return sb.ToString();
        }


        public static string ImportInvoices(InvoicesContext context, string jsonString)
        {
            List<ImportInvoiceDto> invoicesDto = jsonString
                .DeserializeFromJson<List<ImportInvoiceDto>>();

            List<Invoice> invoices = new List<Invoice>();

            StringBuilder sb = new StringBuilder();

            foreach (var invoice in invoicesDto)
            {
                if (!IsValid(invoice) || invoice.DueDate < invoice.IssueDate)
                {
                    sb.AppendLine(ErrorMessage);

                    continue;
                }

                var invoiceToAdd = new Invoice
                {
                    Number = invoice.Number,
                    IssueDate = invoice.IssueDate,
                    DueDate = invoice.DueDate,
                    ClientId = invoice.ClientId,
                    Amount = invoice.Amount,
                    CurrencyType = invoice.CurrencyType
                };

                invoices.Add(invoiceToAdd);
                sb.AppendLine(string.Format(SuccessfullyImportedInvoices, invoice.Number));
            } 
            
            context.Invoices.AddRange(invoices);
            context.SaveChanges();

            return sb.ToString();
        }

        public static string ImportProducts(InvoicesContext context, string jsonString)
        {
            List<ImportProductDto> productsDto = jsonString
                .DeserializeFromJson<List<ImportProductDto>>();

            List<Product> products = new List<Product>();

            StringBuilder sb = new StringBuilder();
            int[] clientIds = context.Clients.Select(x => x.Id).ToArray();

            foreach (var product in productsDto)
            {
                if (!IsValid(product))
                {
                    sb.AppendLine(ErrorMessage);

                    continue;
                }

                var productToAdd = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    CategoryType = product.CategoryType
                };

                foreach (var clientId in product.Clients.Distinct())
                {
                    if (clientIds.Contains(clientId))
                    {
                        productToAdd.ProductsClients.Add(new ProductClient()
                        {
                            ClientId = clientId
                        });
                    }
                    else
                    {
                        sb.AppendLine(ErrorMessage);
                    }
                }

                products.Add(productToAdd);
                sb.AppendLine(string.Format(SuccessfullyImportedProducts, productToAdd.Name, productToAdd.ProductsClients.Count));
            }

            context.Products.AddRange(products);
            context.SaveChanges();

            return sb.ToString();
        }

        public static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
