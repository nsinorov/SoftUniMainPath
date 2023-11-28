using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using ProductShop.Utilities;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProductShop;

public class StartUp
{
    public static void Main()
    {
        //Database
        ProductShopContext context = new ProductShopContext();

        //Variables
        string output = string.Empty;
        string inputXml = string.Empty;

        //01.Import Users
        //inputXml = File.ReadAllText(@"../../../Datasets/users.xml");
        //output = ImportUsers(context, inputXml);

        //02.Import Products
        //inputXml = File.ReadAllText(@"../../../Datasets/products.xml");
        //output = ImportProducts(context, inputXml);

        //03.Import Categories
        //inputXml = File.ReadAllText(@"../../../Datasets/categories.xml");
        //output = ImportCategories(context, inputXml);

        //04.Import Categories and Products
        //inputXml = File.ReadAllText(@"../../../Datasets/categories-products.xml");
        //output = ImportCategoryProducts(context, inputXml);

        //05.Export Products In Range
        //output = GetProductsInRange(context);

        //06.Export Sold Products
        //output = GetSoldProducts(context);

        //07.Export Categories By Products Count
        //output = GetCategoriesByProductsCount(context);

        //08.Export Users and Products
        //output = GetUsersWithProducts(context);

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
    public static string ImportUsers(ProductShopContext context, string inputXml)
    {
        var mapper = CreateMapper();
        var xmlParser = new XmlParser();

        //Deserializing the Xml to User DTOs
        ImportUserDto[] importUserDtos = xmlParser.Deserialize<ImportUserDto[]>(inputXml, "Users");

        //Mapping the User DTOs to Users
        User[] users = mapper.Map<User[]>(importUserDtos);

        //Adding and Saving
        context.Users.AddRange(users);
        context.SaveChanges();

        //Output
        return $"Successfully imported {users.Length}";
    }

    //02.Import Products
    public static string ImportProducts(ProductShopContext context, string inputXml)
    {
        var mapper = CreateMapper();
        var xmlParser = new XmlParser();

        //Deserializing the Xml to Product DTOs
        ImportProductDto[] productDtos = xmlParser.Deserialize<ImportProductDto[]>(inputXml, "Products");

        //Mapping the Product DTOs to Products
        ICollection<Product> products = mapper.Map<Product[]>(productDtos);

        //Adding and Saving
        context.Products.AddRange(products);
        context.SaveChanges();

        //Output
        return $"Successfully imported {products.Count}";
    }

    //03.Import Categories
    public static string ImportCategories(ProductShopContext context, string inputXml)
    {
        var mapper = CreateMapper();
        var xmlParser = new XmlParser();

        //Deserializing the Xml to Category DTOs
        ImportCategoryDto[] categoryDtos = xmlParser.Deserialize<ImportCategoryDto[]>(inputXml, "Categories");

        //Mapping the Category DTOs to Categories only when their name is not null
        List<Category> categories = new List<Category>();

        foreach (var categoryDto in categoryDtos)
        {
            if (categoryDto.Name != null)
            {
                Category category = mapper.Map<Category>(categoryDto);
                categories.Add(category);
            }
        }

        //Adding and Saving
        context.Categories.AddRange(categories);
        context.SaveChanges();

        //Output
        return $"Successfully imported {categories.Count}";
    }

    //04.Import Categories and Products
    public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
    {
        var mapper = CreateMapper();
        var xmlParser = new XmlParser();

        //Deserializing the Xml to CategoryProduct DTOs
        ImportCategoryProductDto[] categoryProductDtos = xmlParser.Deserialize<ImportCategoryProductDto[]>(inputXml, "CategoryProducts");

        //Mapping the CategoryProduct DTOs to CategorieProducts only when their ids are valid
        List<CategoryProduct> categoryProducts = new List<CategoryProduct>();
        HashSet<int> productIds = context.Products.Select(p => p.Id).ToHashSet<int>();
        HashSet<int> categoryIds = context.Categories.Select(c => c.Id).ToHashSet<int>();

        foreach (var dto in categoryProductDtos)
        {
            if (productIds.Contains(dto.ProductId) && categoryIds.Contains(dto.CategoryId))
            {
                var categoryProduct = mapper.Map<CategoryProduct>(dto);
                categoryProducts.Add(categoryProduct);
            }
        }

        //Adding and Saving
        context.CategoryProducts.AddRange(categoryProducts);
        context.SaveChanges();

        //Output
        return $"Successfully imported {categoryProducts.Count}";
    }

    //05.Export Products In Range
    public static string GetProductsInRange(ProductShopContext context)
    {
        var xmlParser = new XmlParser();

        //Selecting the Products
        var productsInRange = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Take(10)
                .Select(p => new ExportProductDto()
                {
                    Price = p.Price,
                    Name = p.Name,
                    BuyerName = p.Buyer.FirstName + " " + p.Buyer.LastName
                })
                .ToArray();

        //Output
        return xmlParser.Serialize<ExportProductDto[]>(productsInRange, "Products");
    }

    //06.Export Sold Products
    public static string GetSoldProducts(ProductShopContext context)
    {
        var xmlParser = new XmlParser();

        //Selecting the Sold Products
        var usersSoldProducts = context.Users
            .Where(u => u.ProductsSold.Count > 0 && u.ProductsSold.Any(ps => ps.BuyerId != null))
            .OrderBy(u => u.LastName).ThenBy(u => u.FirstName)
            .Take(5)
            .Select(u => new ExportSoldProductsDto
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                SoldProducts = u.ProductsSold.Select(p => new ProductDto()
                {
                    Name = p.Name,
                    Price = p.Price,
                })
                .ToArray()
            })
            .ToArray();

        //Output
        return xmlParser.Serialize<ExportSoldProductsDto[]>(usersSoldProducts, "Users");
    }

    //07.Export Categories By Products Count
    public static string GetCategoriesByProductsCount(ProductShopContext context)
    {
        var xmlParser = new XmlParser();

        //Selecting the Categories
        var categories = context.Categories
            .AsNoTracking()
            .Select(c => new ExportCategoryDto
            {
                Name = c.Name,
                Count = c.CategoryProducts.Count,
                AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price),
                TotalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price)
            })
            .OrderByDescending(exd => exd.Count)
            .ThenBy(exd => exd.TotalRevenue)
            .ToArray();

        //Output
        return xmlParser.Serialize<ExportCategoryDto[]>(categories, "Categories");
    }

    //08.Export Users and Products
    public static string GetUsersWithProducts(ProductShopContext context)
    {
        var xmlParser = new XmlParser();

        //Selecting the Users
        var usersInfo = context
                .Users
                .Where(u => u.ProductsSold.Any())
                .OrderByDescending(u => u.ProductsSold.Count)
                .Select(u => new UserInfo()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProductsCount()
                    {
                        Count = u.ProductsSold.Count,
                        Products = u.ProductsSold.Select(p => new SoldProduct()
                        {
                            Name = p.Name,
                            Price = p.Price
                        })
                        .OrderByDescending(p => p.Price)
                        .ToArray()
                    }
                })
                .Take(10)
                .ToArray();

        ExportUserCountDto exportUserCountDto = new ExportUserCountDto()
        {
            Count = context.Users.Count(u => u.ProductsSold.Any()),
            Users = usersInfo
        };

        //Output
        return xmlParser.Serialize<ExportUserCountDto>(exportUserCountDto, "Users");
    }
}
