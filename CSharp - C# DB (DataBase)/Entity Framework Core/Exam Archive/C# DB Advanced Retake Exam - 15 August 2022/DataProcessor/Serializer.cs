namespace Trucks.DataProcessor
{
    using Data;
    using Newtonsoft.Json;
    using Trucks.DataProcessor.ExportDto;
    using Trucks.Utilities;

    public class Serializer
    {
        //XML Export
        public static string ExportDespatchersWithTheirTrucks(TrucksContext context)
        {
            //Selecting the Clients
            var despatchers = context.Despatchers
                .Where(d => d.Trucks.Any())
                .Select(d => new ExportDespatcherDto
                {
                    TrucksCount = d.Trucks.Count,
                    Name = d.Name,
                    Trucks = d.Trucks
                    .Select(t => new ExportTruckDto
                    {
                        RegistrationNumber = t.RegistrationNumber,
                        MakeType = t.MakeType.ToString()
                    })
                    .OrderBy(t => t.RegistrationNumber)
                    .ToArray()
                })
                .OrderByDescending(t => t.TrucksCount)
                .ThenBy(t => t.Name)
                .ToArray();

            //Output in XML
            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize<ExportDespatcherDto[]>(despatchers, "Despatchers");
        }

        //JSON Export
        public static string ExportClientsWithMostTrucks(TrucksContext context, int capacity)
        {
            //Selecting the Clients
            var clients = context.Clients
                .Where(c => c.ClientsTrucks.Any(ct => ct.Truck.TankCapacity >= capacity))
                .AsEnumerable()
                .Select(c => new
                {
                    Name = c.Name,
                    Trucks = c.ClientsTrucks
                    .Where(ct => ct.Truck.TankCapacity >= capacity)
                    .Select(ct => new
                    {
                        TruckRegistrationNumber = ct.Truck.RegistrationNumber,
                        VinNumber = ct.Truck.VinNumber,
                        TankCapacity = ct.Truck.TankCapacity,
                        CargoCapacity = ct.Truck.CargoCapacity,
                        CategoryType = ct.Truck.CategoryType.ToString(),
                        MakeType = ct.Truck.MakeType.ToString()
                    })
                    .OrderBy(t => t.MakeType)
                    .ThenByDescending(t => t.CargoCapacity)
                    .ToArray()
                })
                .OrderByDescending(c => c.Trucks.Length)
                .ThenBy(c => c.Name)
                .Take(10)
                .ToArray();

            //Output in JSON
            return JsonConvert.SerializeObject(clients, Formatting.Indented);
        }
    }
}
