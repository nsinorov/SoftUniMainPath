using AutoMapper;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;

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

            //04.InputCategoriesAndProducts
            CreateMap<ImportCategoryAndProduct, CategoryProduct>();
        }
    }
}
