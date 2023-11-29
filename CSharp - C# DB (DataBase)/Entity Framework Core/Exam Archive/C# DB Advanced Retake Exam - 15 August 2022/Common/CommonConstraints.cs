namespace Trucks.Common;

public class CommonConstraints
{
    //Client
    public const int ClientNameMinLength = 3;
    public const int ClientNameMaxLength = 40;

    public const int ClientNationalityMinLength = 2;
    public const int ClientNationalityMaxLength = 40;

    //Despatcher
    public const int DespatcherNameMinLength = 2;
    public const int DespatcherNameMaxLength = 40;

    //Truck
    public const string TruckRegistrationNumberRegex = @"^[A-Z]{2}\d{4}[A-Z]{2}$";

    public const int TruckVinNumberMinLength = 17;
    public const int TruckVinNumberMaxLength = 17;

    public const int TruckTankCapacityMinRange = 950;
    public const int TruckTankCapacityMaxRange = 1420;

    public const int TruckCargoCapacityMinRange = 5000;
    public const int TruckCargoCapacityMaxRange = 29000;

    public const int TruckCategoryTypeMinRange = 0;
    public const int TruckCategoryTypeMaxRange = 3;

    public const int TruckMakeTypeMinRange = 0;
    public const int TruckMakeTypeMaxRange = 4;
}