using AutoMapper;
using CarDealer.DTOs.Import;
using CarDealer.Models;

namespace CarDealer
{
    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {
            //09.Import Suppliers
            CreateMap<ImportSupplierDto, Supplier>();

            //10.Import Parts
            CreateMap<ImportPartDto, Part>();

            //11.Import Cars
            CreateMap<ImportCarDto, Car>();

            //12.Import Customers
            CreateMap<ImportCustomerDto, Customer>();

            //13.Import Sales
            CreateMap<ImportSaleDto, Sale>();
        }
    }
}
