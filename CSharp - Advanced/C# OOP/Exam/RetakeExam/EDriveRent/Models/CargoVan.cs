
namespace EDriveRent.Models;

public class CargoVan : Vehicle
{
    private const int MaxMileage = 180;
    public CargoVan(string brand, string model, string licensePlateNumber) 
        : base(brand, model, MaxMileage, licensePlateNumber)
    {
    }
}
