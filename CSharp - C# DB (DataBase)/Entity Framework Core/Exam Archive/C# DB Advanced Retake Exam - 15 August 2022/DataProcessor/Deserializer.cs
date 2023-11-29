namespace Trucks.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Data.SqlTypes;
    using System.Text;
    using Castle.Core.Internal;
    using Data;
    using Newtonsoft.Json;
    using Trucks.Data.Models;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ImportDto;
    using Trucks.Utilities;

    public class Deserializer
    {
        //Messages
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedDespatcher
            = "Successfully imported despatcher - {0} with {1} trucks.";

        private const string SuccessfullyImportedClient
            = "Successfully imported client - {0} with {1} trucks.";

        //XML Import
        public static string ImportDespatcher(TrucksContext context, string xmlString)
        {
            //Deserializing the XML to Despatcher DTOs
            XmlHelper xmlHelper = new XmlHelper();
            ImportDespatcherDto[] despatcherDtos = xmlHelper.Deserialize<ImportDespatcherDto[]>(xmlString, "Despatchers");

            //Finding the Valid Despatcher and Truck DTOs
            HashSet<Despatcher> validDespatchers = new HashSet<Despatcher>();
            StringBuilder sb = new StringBuilder();

            //Despatchers Validation
            foreach (var despatcherDto in despatcherDtos)
            {
                //Invalid Despatcher
                if (!IsValid(despatcherDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (String.IsNullOrEmpty(despatcherDto.Position))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Despatcher
                Despatcher validDespatcher = new Despatcher()
                {
                    Name = despatcherDto.Name,
                    Position = despatcherDto.Position
                };

                //Despatcher's Trucks Validation
                foreach (var truckDto in despatcherDto.Trucks)
                {
                    //Invalid Truck
                    if (!IsValid(truckDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    if (String.IsNullOrEmpty(truckDto.RegistrationNumber))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    //Valid Truck
                    Truck validTruck = new Truck()
                    {
                        RegistrationNumber = truckDto.RegistrationNumber,
                        VinNumber = truckDto.VinNumber,
                        TankCapacity = truckDto.TankCapacity,
                        CargoCapacity = truckDto.CargoCapacity,
                        CategoryType = (CategoryType)truckDto.CategoryType,
                        MakeType = (MakeType)truckDto.MakeType,
                    };
                    //Adding the Valid Truck to it's Valid Despatcher
                    validDespatcher.Trucks.Add(validTruck);
                }
                //Adding the Valid Despatcher to it's Collection
                validDespatchers.Add(validDespatcher);
                sb.AppendLine(String.Format(SuccessfullyImportedDespatcher, validDespatcher.Name, validDespatcher.Trucks.Count));
            }
            //Adding and Saving
            context.Despatchers.AddRange(validDespatchers);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //JSON Import
        public static string ImportClient(TrucksContext context, string jsonString)
        {
            //Deserializing the JSON to Client DTOs
            ImportClientDto[] clientDtos = JsonConvert.DeserializeObject<ImportClientDto[]>(jsonString);

            //Finding the Valid Client and Truck DTOs
            HashSet<Client> validClients = new HashSet<Client>();
            int[] trucksIds = context.Trucks.Select(t => t.Id).ToArray();
            StringBuilder sb = new StringBuilder();

            //Clients Validation
            foreach (var clientDto in clientDtos)
            {
                //Invalid Client
                if (!IsValid(clientDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (clientDto.Type.ToLower() == "usual")
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Client
                Client validClient = new Client()
                {
                    Name = clientDto.Name,
                    Nationality = clientDto.Nationality,
                    Type = clientDto.Type
                };

                //Valid Client's Trucks Validation
                foreach (var truckId in clientDto.TrucksIds.Distinct())
                {
                    //Invalid ID
                    if (!trucksIds.Contains(truckId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    //Valid Truck Id
                    validClient.ClientsTrucks.Add(new ClientTruck()
                    {
                        TruckId = truckId
                    });
                }
                //Adding the Valid Client to it's Collection
                validClients.Add(validClient);
                sb.AppendLine(String.Format(SuccessfullyImportedClient, validClient.Name, validClient.ClientsTrucks.Count()));
            }
            //Adding and Saving
            context.Clients.AddRange(validClients);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //DTOs Validation
        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}