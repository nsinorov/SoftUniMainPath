namespace Invoices.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;
    using System.Text.Json.Serialization;
    using System.Xml.Serialization;
    using CarDealer.Utilities;
    using Invoices.Data;
    using Invoices.Data.Enums;
    using Invoices.Data.Models;
    using Invoices.DataProcessor.ImportDto;
    using Newtonsoft.Json;

    public class Deserializer
    {
        //Messages
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedClients
            = "Successfully imported client {0}.";

        private const string SuccessfullyImportedInvoices
            = "Successfully imported invoice with number {0}.";

        private const string SuccessfullyImportedProducts
            = "Successfully imported product - {0} with {1} clients.";

        //XML Import
        public static string ImportClients(InvoicesContext context, string xmlString)
        {
            var xmlParser = new XmlParser();

            //Deserializing the XML to ClientDTOs
            ImportClientDto[] clientDtos = xmlParser.Deserialize<ImportClientDto[]>(xmlString, "Clients");

            //Selecting only the Valid Clients and their Addresses
            StringBuilder sb = new StringBuilder();
            HashSet<Client> clients = new HashSet<Client>();

            //Clients
            foreach (var clientDto in clientDtos)
            {
                //Invalid Client
                if (!IsValid(clientDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Client
                Client client = new Client()
                {
                    Name = clientDto.Name,
                    NumberVat = clientDto.NumberVat
                };

                //Client's Addresses
                foreach (var addressDto in clientDto.Addresses)
                {
                    //Invalid Address
                    if (!IsValid(addressDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    //Valid Address
                    Address address = new Address()
                    {
                        StreetName = addressDto.StreetName,
                        StreetNumber = addressDto.StreetNumber,
                        PostCode = addressDto.PostCode,
                        City = addressDto.City,
                        Country = addressDto.Country
                    };

                    //Adding the Address to the Client
                    client.Addresses.Add(address);
                }
                //Adding the Client to the collection of valid Clients
                clients.Add(client);
                sb.AppendLine(String.Format(SuccessfullyImportedClients, client.Name));
            }
            //Saving the data to the database
            context.Clients.AddRange(clients);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //JSON Import
        public static string ImportInvoices(InvoicesContext context, string jsonString)
        {
            //Deserializing the JSON to InvoiceDTOs
            ImportInvoiceDto[] invoiceDtos = JsonConvert.DeserializeObject<ImportInvoiceDto[]>(jsonString);

            //Selecting only the Valid Invoices
            StringBuilder sb = new StringBuilder();
            HashSet<Invoice> invoices = new HashSet<Invoice>();
            int[] clientsIds = context.Clients.Select(c => c.Id).ToArray();

            foreach (var invoiceDto in invoiceDtos)
            {
                //Invalid Invoice or Invalid Client Id
                if (!IsValid(invoiceDto) || !clientsIds.Contains(invoiceDto.ClientId))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                //Invalid Dates
                DateTime issueDate = DateTime.ParseExact(invoiceDto.IssueDate, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                DateTime dueDate = DateTime.ParseExact(invoiceDto.DueDate, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

                if (issueDate > dueDate)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                //Valid Invoice and ClientId
                Invoice invoice = new Invoice()
                {
                    Number = invoiceDto.Number,
                    IssueDate = issueDate,
                    DueDate = dueDate,
                    Amount = invoiceDto.Amount,
                    CurrencyType = (CurrencyType)invoiceDto.CurrencyType,
                    ClientId = invoiceDto.ClientId
                };
                //Adding the Invoice to the Valid Invoices
                invoices.Add(invoice);
                sb.AppendLine(String.Format(SuccessfullyImportedInvoices, invoice.Number));
            }
            //Saving the data to the database
            context.Invoices.AddRange(invoices);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        public static string ImportProducts(InvoicesContext context, string jsonString)
        {
            //Deserializing the JSON to ProductDTOs
            ImportProductDto[] productDtos = JsonConvert.DeserializeObject<ImportProductDto[]>(jsonString);

            //Selecting only the Valid Products and their Clients
            StringBuilder sb = new StringBuilder();
            List<Product> products = new List<Product>();
            int[] clientsIds = context.Clients.Select(c => c.Id).ToArray();

            //Products
            foreach (var productDto in productDtos)
            {
                //Invalid Product
                if (!IsValid(productDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Product
                Product product = new Product()
                {
                    Name = productDto.Name,
                    Price = productDto.Price,
                    CategoryType = (CategoryType)productDto.CategoryType
                };

                //Clients
                foreach (var clientId in productDto.Clients.Distinct())
                {
                    //Invalid Client Id
                    if (!clientsIds.Contains(clientId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    //Valid Client Id
                    product.ProductsClients.Add(new ProductClient()
                    {
                        ClientId = clientId
                    });
                }
                //Adding the Product to the Valid Products
                products.Add(product);
                sb.AppendLine(string.Format(SuccessfullyImportedProducts, product.Name, product.ProductsClients.Count));
            }
            //Saving the data to the database
            context.Products.AddRange(products);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //DTO Validation
        public static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    } 
}