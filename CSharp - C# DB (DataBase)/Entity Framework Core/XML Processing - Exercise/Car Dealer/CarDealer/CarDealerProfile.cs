using AutoMapper;
using CarDealer.DTOs.Import;
using CarDealer.Models;

namespace CarDealer;

public class CarDealerProfile : Profile
{
    public CarDealerProfile()
    {
        //09.Import Suppliers
        CreateMap<ImportSupplierDto, Supplier>();

        //10.Import Suppliers
        CreateMap<ImportPartDto, Part>();

        //12.Import Customers
        CreateMap<ImportCustomerDto, Customer>();

        //13.Import Sales
        CreateMap<ImportSaleDto, Sale>();
    }
}