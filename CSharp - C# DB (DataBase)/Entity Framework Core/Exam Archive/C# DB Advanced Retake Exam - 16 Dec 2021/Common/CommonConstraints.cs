namespace Artillery.Common;

public class CommonConstraints
{
    //Manufacturer
    public const int ManufacturerNameMinLength = 4;
    public const int ManufacturerNameMaxLength = 40;

    public const int ManufacturerFoundedMinLength = 10;
    public const int ManufacturerFoundedMaxLength = 100;

    //Shell
    public const double ShellWeightMinRange = 2.0;
    public const double ShellWeightMaxRange = 1680.0;

    public const int ShellCaliberMinLength = 4;
    public const int ShellCaliberMaxLength = 30;

    //Country
    public const int CountryNameMinLength = 4;
    public const int CountryNameMaxLength = 60;

    public const int CountryArmySizeMinRange = 50000;
    public const int CountryArmySizeMaxRange = 10000000;

    //Gun
    public const int GunWeightMinRange = 100;
    public const int GunWeightMaxRange = 1350000;

    public const double BarrelLengthMinRange = 2.0;
    public const double BarrelLengthMaxRange = 35.0;

    public const int GunRangeMinRange = 1;
    public const int GunRangeMaxRange = 100000;
}