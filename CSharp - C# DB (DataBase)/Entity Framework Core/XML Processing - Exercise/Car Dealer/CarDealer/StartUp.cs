using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using ProductShop.Utilities;
using System.Linq;
using static CarDealer.DTOs.Export.ExportCarPartsDto;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            //Database
            CarDealerContext context = new CarDealerContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //Variables
            string output = string.Empty;
            string inputXml = string.Empty;

            //09.Import Suppliers
            //inputXml = File.ReadAllText(@"../../../Datasets/suppliers.xml");
            //output = ImportSuppliers(context, inputXml);

            //10.Import Parts
            //inputXml = File.ReadAllText(@"../../../Datasets/parts.xml");
            //output = ImportParts(context, inputXml);

            //11.Import Cars
            //inputXml = File.ReadAllText(@"../../../Datasets/cars.xml");
            //output = ImportCars(context, inputXml);

            //12.Import Customers
            //inputXml = File.ReadAllText(@"../../../Datasets/customers.xml");
            //output = ImportCustomers(context, inputXml);

            //14.Export Sales
            //output = GetCarsWithDistance(context);

            //15.Get Cars from Make BMW
            //output = GetCarsFromMakeBmw(context);

            //16.Export Local Suppliers
            //output = GetLocalSuppliers(context);

            //17.Export Cars With Their List Of Parts
            //output = GetCarsWithTheirListOfParts(context);

            //18.Export Total Sales By Customer
            //output = GetTotalSalesByCustomer(context);

            //19.Export Sales With Applied Discount
            //output = GetSalesWithAppliedDiscount(context);


            Console.WriteLine(output);
        }

        //Mapper Creation
        private static IMapper CreateMapper()
        {
            MapperConfiguration config = new MapperConfiguration(config =>
            {
                config.AddProfile<CarDealerProfile>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        }

        //09.Import Suppliers
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var mapper = CreateMapper();
            var xmlParser = new XmlParser();

            //Deserializing the Xml to Supplier DTOs
            ImportSupplierDto[] supplierDtos = xmlParser.Deserialize<ImportSupplierDto[]>(inputXml, "Suppliers");

            //Mapping the Supplier DTOs to Suppliers
            Supplier[] suppliers = mapper.Map<Supplier[]>(supplierDtos);

            //Adding and Saving
            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            //Output
            return $"Successfully imported {suppliers.Length}";
        }

        //10.Import Parts
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var mapper = CreateMapper();
            var xmlParser = new XmlParser();

            //Deserializing the Xml to Part DTOs
            ImportPartDto[] partDtos = xmlParser.Deserialize<ImportPartDto[]>(inputXml, "Parts");

            //Mapping the Part DTOs to Parts only if the SupplierId exists
            var allSuppliers = context.Suppliers.ToArray();
            var supplierIds = context.Suppliers.Select(s => s.Id).ToArray();
            List<Part> parts = new List<Part>();

            foreach (var partDto in partDtos)
            {
                if (supplierIds.Contains(partDto.SupplierId))
                {
                    parts.Add(mapper.Map<Part>(partDto));
                }
            }

            //Adding and Saving
            context.Parts.AddRange(parts);
            context.SaveChanges();

            //Output
            return $"Successfully imported {parts.Count}";
        }

        //11.Import Cars
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            var mapper = CreateMapper();
            var xmlParser = new XmlParser();

            //Deserializing the Xml to Part DTOs
            ImportCarsDto[] carsDtos = xmlParser.Deserialize<ImportCarsDto[]>(inputXml, "Cars");

            //Mapping the Car DTOs to Cars only if their parts are unique
            List<Car> cars = new List<Car>();
            List<PartCar> partCars = new List<PartCar>();
            int[] allPartIds = context.Parts.Select(p => p.Id).ToArray();
            int carId = 1;

            foreach (var dto in carsDtos)
            {
                Car car = new Car()
                {
                    Make = dto.Make,
                    Model = dto.Model,
                    TraveledDistance = dto.TraveledDistance
                };

                cars.Add(car);

                foreach (int partId in dto.Parts
                    .Where(p => allPartIds.Contains(p.PartId))
                    .Select(p => p.PartId)
                    .Distinct())
                {
                    PartCar partCar = new PartCar()
                    {
                        CarId = carId,
                        PartId = partId
                    };
                    partCars.Add(partCar);
                }
                carId++;
            }

            //Adding and Saving
            context.Cars.AddRange(cars);
            context.PartsCars.AddRange(partCars);
            context.SaveChanges();

            //Output
            return $"Successfully imported {cars.Count}";
        }

        //12.Import Customers
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            var mapper = CreateMapper();
            var xmlParser = new XmlParser();

            //Deserializing the Xml to Customer DTOs
            ImportCustomerDto[] customerDtos = xmlParser.Deserialize<ImportCustomerDto[]>(inputXml, "Customers");

            //Mapping the Customer DTOs to Customers
            Customer[] customers = mapper.Map<Customer[]>(customerDtos);

            //Adding and Saving
            context.Customers.AddRange(customers);
            context.SaveChanges();

            //Output
            return $"Successfully imported {customers.Length}";
        }

        //13.Import Sales
        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            var mapper = CreateMapper();
            var xmlParser = new XmlParser();

            //Deserializing the Xml to Sale DTOs
            ImportSaleDto[] saleDtos = xmlParser.Deserialize<ImportSaleDto[]>(inputXml, "Sales");

            //Mapping the Sale DTOs to Sales
            HashSet<int> carIds = context.Cars.Select(c => c.Id).ToHashSet<int>();
            var sales = new List<Sale>();

            foreach (var saleDto in saleDtos)
            {
                if (carIds.Contains(saleDto.CarId))
                {
                    sales.Add(mapper.Map<Sale>(saleDto));
                }
            }

            //Adding and Saving
            context.Sales.AddRange(sales);
            context.SaveChanges();

            //Output
            return $"Successfully imported {sales.Count}";
        }

        //14.Export Sales
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var xmlParser = new XmlParser();

            //Finding the Cars
            var carDtos = context.Cars
                .Where(c => c.TraveledDistance > 2000000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .Select(c => new ExportCarDistanceDto
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .ToArray();

            //Output
            return xmlParser.Serialize<ExportCarDistanceDto[]>(carDtos, "cars");
        }

        //15.Export Sales
        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var xmlParser = new XmlParser();

            //Finding the Cars
            var carDtos = context.Cars
                .Where(c => c.Make.ToUpper() == "BMW")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .Select(c => new ExportCarMake
                {
                    Id = c.Id,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .ToArray();

            //Output
            return xmlParser.Serialize<ExportCarMake[]>(carDtos, "cars");
        }

        //16.Export Local Suppliers
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var xmlParser = new XmlParser();

            //Finding the Suppliers
            var supplierDtos = context.Suppliers
                .Where(s => !s.IsImporter)
                .Select(s => new ExportLocalSupplierDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count()
                })
                .ToArray();

            //Output
            return xmlParser.Serialize<ExportLocalSupplierDto[]>(supplierDtos, "suppliers");
        }

        //17.Export Cars With Their List Of Parts
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var xmlParser = new XmlParser();

            //Finding the Cars
            ExportCarPartsDto[] carsPartsDtos = context.Cars
                .OrderByDescending(c => c.TraveledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .Select(c => new ExportCarPartsDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                    Parts = c.PartsCars.Select(pc => new PartsDto()
                    {
                        Name = pc.Part.Name,
                        Price = pc.Part.Price
                    })
                    .OrderByDescending(p => p.Price)
                    .ToArray()
                })
                .ToArray();

            //Output
            return xmlParser.Serialize<ExportCarPartsDto[]>(carsPartsDtos, "cars");
        }

        //18.Export Total Sales By Customer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var xmlParser = new XmlParser();

            //Finding the Sales
            var tempDto = context.Customers
                .Where(c => c.Sales.Any())
                .Select(c => new
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count(),
                    SalesInfo = c.Sales.Select(s => new
                    {
                        Prices = c.IsYoungDriver
                            ? s.Car.PartsCars.Sum(p => Math.Round((double)p.Part.Price * 0.95, 2))
                            : s.Car.PartsCars.Sum(p => (double)p.Part.Price)
                    }).ToArray(),
                })
                .ToArray();

            TotalSalesByCustomerDto[] totalSalesDtos = tempDto
                .OrderByDescending(t => t.SalesInfo.Sum(s => s.Prices))
                .Select(t => new TotalSalesByCustomerDto()
                {
                    FullName = t.FullName,
                    BoughtCars = t.BoughtCars,
                    SpentMoney = t.SalesInfo.Sum(s => s.Prices).ToString("f2")
                })
                .ToArray();

            //Output
            return xmlParser.Serialize<TotalSalesByCustomerDto[]>(totalSalesDtos, "customers");

        }

        //19.Export Sales With Applied Discount
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var xmlParser = new XmlParser();

            //Finding the Sales
            SalesWithAppliedDiscountDto[] salesDtos = context
                .Sales
                .Select(s => new SalesWithAppliedDiscountDto()
                {
                    SingleCar = new SingleCar()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TraveledDistance
                    },
                    Discount = (int)s.Discount,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartsCars.Sum(p => p.Part.Price),
                    PriceWithDiscount = Math.Round((double)(s.Car.PartsCars.Sum(p => p.Part.Price) * (1 - (s.Discount / 100))), 4)
                })
                .ToArray();

            //Output
            return xmlParser.Serialize<SalesWithAppliedDiscountDto[]>(salesDtos, "sales");
        }
    }
}