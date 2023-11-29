using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CarDealer;

public class StartUp
{
    public static void Main()
    {
        //Database
        CarDealerContext context = new CarDealerContext();
        //context.Database.EnsureDeleted();
        //context.Database.EnsureCreated();

        //Variables
        string inputJson = string.Empty;
        string output = string.Empty;

        //09.Import Suppliers
        //inputJson = File.ReadAllText(@"../../../Datasets/suppliers.json");
        //output = ImportSuppliers(context, inputJson);

        //10.Import Parts
        //inputJson = File.ReadAllText(@"../../../Datasets/parts.json");
        //output = ImportParts(context, inputJson);

        //11.Import Cars
        //inputJson = File.ReadAllText(@"../../../Datasets/cars.json");
        //output = ImportCars(context, inputJson);

        //12.Import Customers
        //inputJson = File.ReadAllText(@"../../../Datasets/customers.json");
        //output = ImportCustomers(context, inputJson);

        //13.Import Sales
        //inputJson = File.ReadAllText(@"../../../Datasets/sales.json");
        //output = ImportSales(context, inputJson);

        //14.Export Ordered Customers
        //output = GetOrderedCustomers(context);

        //15.Export Cars From Make Toyota
        //output = GetCarsFromMakeToyota(context);

        //16.Export Local Suppliers
        //output = GetLocalSuppliers(context);

        //17.Export Cars With Their List Of Parts
        //output = GetCarsWithTheirListOfParts(context);

        //18.Export Total Sales By Customer
        //output = GetTotalSalesByCustomer(context);

        //19.Export Sales With Applied Discount
        //output = GetSalesWithAppliedDiscount(context);

        //Output
        Console.WriteLine(output);
    }

    //Mapper
    public static IMapper CreateMapper()
    {
        MapperConfiguration configuration = new MapperConfiguration(config =>
        {
            config.AddProfile<CarDealerProfile>();
        });

        IMapper mapper = configuration.CreateMapper();

        return mapper;
    }

    //09.Import Suppliers
    public static string ImportSuppliers(CarDealerContext context, string inputJson)
    {
        var mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportSupplierDto[] suppliersDtos = JsonConvert.DeserializeObject<ImportSupplierDto[]>(inputJson);

        //Mapping the Users from their DTO
        Supplier[] suppliers = mapper.Map<Supplier[]>(suppliersDtos);

        //Adding the Suppliers
        context.Suppliers.AddRangeAsync(suppliers);
        context.SaveChanges();

        //Output
        return $"Successfully imported {suppliers.Length}.";
    }

    //10.Import Parts
    public static string ImportParts(CarDealerContext context, string inputJson)
    {
        var mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportPartDto[] partsDtos = JsonConvert.DeserializeObject<ImportPartDto[]>(inputJson);

        //Mapping the Parts from their DTO
        ICollection<Part> parts = new List<Part>();

        foreach (var part in partsDtos)
        {
            if (context.Suppliers.Any(s => s.Id == part.SupplierId))
            {
                parts.Add(mapper.Map<Part>(part));
            }
        }

        //Adding the Parts
        context.Parts.AddRangeAsync(parts);
        context.SaveChanges();

        //Output
        return $"Successfully imported {parts.Count}.";
    }

    //11.Import Cars
    public static string ImportCars(CarDealerContext context, string inputJson)
    {
        IMapper mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportCarDto[] importCarDtos = JsonConvert.DeserializeObject<ImportCarDto[]>(inputJson);

        //Mapping the Cars from their DTOs
        ICollection<Car> carsToAdd = new HashSet<Car>();

        foreach (var carDto in importCarDtos)
        {
            Car currentCar = mapper.Map<Car>(carDto);

            foreach (var id in carDto.PartsIds)
            {
                if (context.Parts.Any(p => p.Id == id))
                {
                    currentCar.PartsCars.Add(new PartCar
                    {
                        PartId = id,
                    });
                }
            }

            carsToAdd.Add(currentCar);
        }

        //Adding the Cars
        context.Cars.AddRange(carsToAdd);
        context.SaveChanges();

        //Output
        return $"Successfully imported {carsToAdd.Count}.";
    }

    //12.Import Customers
    public static string ImportCustomers(CarDealerContext context, string inputJson)
    {
        var mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportCarDto[] customerDtos = JsonConvert.DeserializeObject<ImportCarDto[]>(inputJson);

        //Mapping the Customers from their DTOs
        Customer[] customers = JsonConvert.DeserializeObject<Customer[]>(inputJson);

        //Adding the Customers
        context.Customers.AddRange(customers);
        context.SaveChanges();

        //Output
        return $"Successfully imported {customers.Length}.";
    }

    //13.Import Sales
    public static string ImportSales(CarDealerContext context, string inputJson)
    {
        var mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportSaleDto[] salesDtos = JsonConvert.DeserializeObject<ImportSaleDto[]>(inputJson);

        //Mapping the Sales from their DTOs
        Sale[] sales = JsonConvert.DeserializeObject<Sale[]>(inputJson);

        //Adding the Sales
        context.Sales.AddRange(sales);
        context.SaveChanges();

        //Output
        return $"Successfully imported {sales.Length}.";
    }

    //14.Export Ordered Customers
    public static string GetOrderedCustomers(CarDealerContext context)
    {
        //Finding the Customers
        var customers = context.Customers
            .AsNoTracking()
            .OrderBy(c => c.BirthDate)
            .ThenBy(c => c.IsYoungDriver)
            .Select(c => new
            {
                c.Name,
                BirthDate = c.BirthDate.ToString("dd/MM/yyyy"),
                c.IsYoungDriver
            })
            .ToArray();

        //Output
        return JsonConvert.SerializeObject(customers, Formatting.Indented);
    }

    //15.Export Cars From Make Toyota
    public static string GetCarsFromMakeToyota(CarDealerContext context)
    {
        //Finding the Cars
        var cars = context.Cars
            .AsNoTracking()
            .Where(c => c.Make.ToLower() == "toyota")
            .Select(c => new 
            {
                c.Id,
                c.Make,
                c.Model,
                c.TraveledDistance
            })
            .OrderBy(c => c.Model)
            .ThenByDescending(c => c.TraveledDistance)
            .ToArray();

        //Output
        return JsonConvert.SerializeObject(cars, Formatting.Indented);
    }

    //16.Export Local Suppliers
    public static string GetLocalSuppliers(CarDealerContext context)
    {
        //Finding the Suppliers
        var suppliers = context.Suppliers
            .AsNoTracking()
            .Where(s => !s.IsImporter)
            .Select(s => new
            {
                s.Id,
                s.Name,
                PartsCount = s.Parts.Count,
            })
            .ToArray();

        //Output
        return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
    }

    //17.Export Cars With Their List Of Parts
    public static string GetCarsWithTheirListOfParts(CarDealerContext context)
    {
        //Finding the Cars
        var cars = context.Cars
            .AsNoTracking()
            .Select(c => new
            {
                car = new
                {
                    c.Make,
                    c.Model,
                    c.TraveledDistance
                },
                parts = c.PartsCars
                    .Select(p => new
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price.ToString("f2"),
                    }).ToArray()
            }).ToArray();


        //Output
        return JsonConvert.SerializeObject(cars, Formatting.Indented);
    }

    //18.Export Total Sales By Customer
    public static string GetTotalSalesByCustomer(CarDealerContext context)
    {
        //Finding the Customers
        var customers = context.Customers
                .Where(c => c.Sales.Count() > 0)
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count(),
                    spentMoney = c.Sales.Sum(s => s.Car.PartsCars.Sum(p => p.Part.Price))
                })
                .OrderByDescending(x => x.spentMoney)
                .ThenByDescending(x => x.boughtCars)
                .ToList();

        //Output
        return JsonConvert.SerializeObject(customers, Formatting.Indented);
    }

    //19.Export Sales With Applied Discount
    public static string GetSalesWithAppliedDiscount(CarDealerContext context)
    {
        //Finding the Sales
        var sales = context.Sales
            .Take(10)
            .Select(s => new
            {
                car = new
                {
                    Make = s.Car.Make,
                    Model = s.Car.Model,
                    TraveledDistance = s.Car.TraveledDistance
                },
                customerName = s.Customer.Name,
                discount = s.Discount.ToString("f2"),
                price = s.Car.PartsCars.Sum(pc => pc.Part.Price).ToString("f2"),
                priceWithDiscount = ((s.Car.PartsCars.Sum(pc => pc.Part.Price) * (1 - s.Discount / 100))).ToString("f2")
            })
            .ToArray();

        //Output
        return JsonConvert.SerializeObject(sales, Formatting.Indented);
    }
}