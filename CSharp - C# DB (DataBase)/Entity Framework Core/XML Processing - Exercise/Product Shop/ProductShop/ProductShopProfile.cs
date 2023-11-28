using AutoMapper;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using ProductShop.Utilities;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            //01.Import Users
            CreateMap<ImportUserDto, User>();

            //02.Import Products
            CreateMap<ImportProductDto, Product>();

            //03.Import Categories
            CreateMap<ImportCategoryDto, Category>();

            //04.Import Categories and Products
            CreateMap<ImportCategoryProductDto, CategoryProduct>();

            //05.Export Products In Range
            CreateMap<Product, ExportProductDto>();
        }
    }
}
