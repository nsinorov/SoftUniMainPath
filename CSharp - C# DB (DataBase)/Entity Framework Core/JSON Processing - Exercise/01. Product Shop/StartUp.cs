using ProductShop.Data;
using ProductShop.DTOs.Import;
using Newtonsoft.Json;
using AutoMapper;
using ProductShop.Models;
using Microsoft.EntityFrameworkCore;
using ProductShop.DTOs.Export;
using AutoMapper.QueryableExtensions;
using System.Runtime.CompilerServices;

namespace ProductShop;

public class StartUp
{
    public static void Main()
    {
        //Database
        ProductShopContext context = new ProductShopContext();
        
        //Variables
        string inputJson = string.Empty;
        string output = string.Empty;

        //01.Import Users
        //inputJson = File.ReadAllText(@"../../../Datasets/users.json");
        //output = ImportUsers(context, inputJson);

        //02.Import Products
        //inputJson = File.ReadAllText(@"../../../Datasets/products.json");
        //output = ImportProducts(context, inputJson);

        //03.Import Categories
        //inputJson = File.ReadAllText(@"../../../Datasets/categories.json");
        //output = ImportCategories(context, inputJson);

        //O4.Import Categories and Products
        //inputJson = File.ReadAllText(@"../../../Datasets/categories-products.json");
        //output = ImportCategories(context, inputJson);

        //05.Export Products in Range
        //output = GetProductsInRange(context);

        //06.Export Sold Products
        //output = GetSoldProducts(context);

        //07.Export Categories By Products Count
        //output = GetCategoriesByProductsCount(context);

        //08.Export Users and Products
        //output = GetUsersWithProducts(context);

        //Output
        Console.WriteLine(output);
    }

    //Mapper Creation
    private static IMapper CreateMapper()
    {
        MapperConfiguration config = new MapperConfiguration(config =>
        {
            config.AddProfile<ProductShopProfile>();
        });

        var mapper = config.CreateMapper();
        return mapper;
    }

    //01.Import Users
    public static string ImportUsers(ProductShopContext context, string inputJson)
    {
        IMapper mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportUserDto[] usersDto = JsonConvert.DeserializeObject<ImportUserDto[]>(inputJson);

        //Mapping the Users from their DTO
        User[] users = mapper.Map<User[]>(usersDto);

        //Adding the Users
        context.Users.AddRangeAsync(users);
        context.SaveChanges();

        //Output
        return $"Successfully imported {users.Length}";
    }

    //02.Import Products
    public static string ImportProducts(ProductShopContext context, string inputJson)
    {
        var mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportProductDto[] productsDto = JsonConvert.DeserializeObject<ImportProductDto[]>(inputJson);

        //Mapping the Products from their DTO
        Product[] products = mapper.Map<Product[]>(productsDto);

        //Adding the Products
        context.Products.AddRangeAsync(products);
        context.SaveChanges();

        //Output
        return $"Successfully imported {products.Length}";
    }

    //03.Import Categories
    public static string ImportCategories(ProductShopContext context, string inputJson)
    {
        var mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportCategoryDto[] allCategoryDtos = JsonConvert.DeserializeObject<ImportCategoryDto[]>(inputJson);

        //Mapping only the Categories which name is not null
        var categoriesDto = allCategoryDtos
            .Where(c => c.Name != null)
            .ToArray();

        Category[] categories = mapper.Map<Category[]>(categoriesDto);

        //Adding the Categories
        context.Categories.AddRangeAsync(categories);
        context.SaveChanges();

        //Output
        return $"Successfully imported {categories.Length}";
    }

    //O4.Import Categories and Products
    public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
    {
        var mapper = CreateMapper();

        //Turning the json file to a DTO
        ImportCategoryAndProduct[] categoriesAndProductsDto = JsonConvert.DeserializeObject<ImportCategoryAndProduct[]>(inputJson);

        //Mapping the Categories and Products from their DTO
        var categoriesAndProducts = mapper.Map<CategoryProduct[]>(categoriesAndProductsDto);

        //Adding the Categories and Products
        context.CategoriesProducts.AddRangeAsync(categoriesAndProducts);
        context.SaveChanges();

        //Output
        return $"Successfully imported {categoriesAndProducts.Length}";
    }

    //05.Export Products in Range
    public static string GetProductsInRange(ProductShopContext context)
    {
        //Getting the products as a DTO
        var products = context.Products
            .AsNoTracking()
            .Where(p => p.Price >= 500 && p.Price <= 1000)
            .Select(p => new ExportProductInRange
            {
                ProductName = p.Name,
                ProductPrice = p.Price,
                SellerName = $"{p.Seller.FirstName} {p.Seller.LastName}"
            })
            .OrderBy(p => p.ProductPrice)
            .ToArray();

        //Returning a json file from a DTO
        return JsonConvert.SerializeObject(products, Formatting.Indented);
    }

    //06.Export Sold Products
    public static string GetSoldProducts(ProductShopContext context)
    {
        var usersProducts = context.Users
            .Where(u => u.ProductsSold.Any(ps => ps.BuyerId != null))
            .OrderBy(u => u.LastName)
            .ThenBy(u => u.FirstName)
            .AsNoTracking()
            .Select(u => new
            {
                firstName = u.FirstName,
                lastName = u.LastName,
                soldProducts = u.ProductsSold
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        buyerFirstName = p.Buyer.FirstName,
                        buyerLastName = p.Buyer.LastName

                    }).ToArray()

            }).ToArray();

        return JsonConvert.SerializeObject(usersProducts, Formatting.Indented);
    }

    //07.Export Categories By Products Count
    public static string GetCategoriesByProductsCount(ProductShopContext context)
    {
        var categories = context.Categories
            .AsNoTracking()
            .OrderByDescending(c => c.CategoriesProducts.Count)
            .Select(c => new
            {
                category = c.Name,
                productsCount = c.CategoriesProducts.Count,
                averagePrice = c.CategoriesProducts.Average(cp => cp.Product.Price).ToString("f2"),
                totalRevenue = c.CategoriesProducts.Sum(cp => cp.Product.Price).ToString("f2")
            })
            .ToArray();

        return JsonConvert.SerializeObject(categories, Formatting.Indented);
    }

    //08.Export Users and Products
    public static string GetUsersWithProducts(ProductShopContext context)
    {
        var users = context.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = new
                    {
                        count = u.ProductsSold.Count(p => p.BuyerId != null),
                        products = u.ProductsSold
                            .Where(p => p.BuyerId != null)
                            .Select(p => new
                            {
                                name = p.Name,
                                price = p.Price
                            }).ToArray()
                    }
                })
                .AsNoTracking()
                .OrderByDescending(x => x.soldProducts.count)
                .ToArray();

        var resultUsers = new
        {
            usersCount = users.Length,
            users = users
        };

        return JsonConvert.SerializeObject(resultUsers, Formatting.Indented, new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore,
        });
    }
}
