namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.Data.Enums;
    using Artillery.Data.Models;
    using Artillery.DataProcessor.ImportDto;
    using Artillery.Utilities;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Deserializer
    {
        //Messages
        private const string ErrorMessage =
            "Invalid data.";
        private const string SuccessfulImportCountry =
            "Successfully import {0} with {1} army personnel.";
        private const string SuccessfulImportManufacturer =
            "Successfully import manufacturer {0} founded in {1}.";
        private const string SuccessfulImportShell =
            "Successfully import shell caliber #{0} weight {1} kg.";
        private const string SuccessfulImportGun =
            "Successfully import gun {0} with a total weight of {1} kg. and barrel length of {2} m.";

        //XML Import
        public static string ImportCountries(ArtilleryContext context, string xmlString)
        {
            //Deserializing the XML to Country DTOs
            XmlHelper xmlHelper = new XmlHelper();
            ImportCountriesDto[] countryDtos = xmlHelper.Deserialize<ImportCountriesDto[]>(xmlString, "Countries");

            //Selecting only the Valid Countries
            HashSet<Country> validCountries = new HashSet<Country>();
            StringBuilder sb = new StringBuilder();

            foreach (var countryDto in countryDtos)
            {
                //Invalid Country
                if (!IsValid(countryDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Country
                validCountries.Add(new Country()
                {
                    CountryName = countryDto.CountryName,
                    ArmySize = countryDto.ArmySize
                });
                sb.AppendLine(String.Format(SuccessfulImportCountry, countryDto.CountryName, countryDto.ArmySize));
            }
            //Adding and Saving
            context.Countries.AddRange(validCountries);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //XML Import
        public static string ImportManufacturers(ArtilleryContext context, string xmlString)
        {
            //Deserializing the XML to Manufacturer DTOs
            XmlHelper xmlHelper = new XmlHelper();
            ImportManufacturerDto[] manufacturerDtos = xmlHelper.Deserialize<ImportManufacturerDto[]>(xmlString, "Manufacturers");

            //Selecting only the Valid Manufacturers
            HashSet<Manufacturer> validManufacturers = new HashSet<Manufacturer>();
            StringBuilder sb = new StringBuilder();

            foreach (var manufacturerDto in manufacturerDtos)
            {
                //Invalid Manufacturer
                if (!IsValid(manufacturerDto) || validManufacturers.Any(vm => vm.ManufacturerName == manufacturerDto.ManufacturerName))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Manufacturer
                validManufacturers.Add(new Manufacturer()
                {
                    ManufacturerName = manufacturerDto.ManufacturerName,
                    Founded = manufacturerDto.Founded
                });

                string[] manufacturerInfo = manufacturerDto.Founded.Split(", ").ToArray();
                string manufacturerTownAndCountry = manufacturerInfo[manufacturerInfo.Length-2] + ", " + manufacturerInfo[manufacturerInfo.Length-1];  

                sb.AppendLine(String.Format(SuccessfulImportManufacturer, manufacturerDto.ManufacturerName, manufacturerTownAndCountry));
            }
            //Adding and Saving
            context.Manufacturers.AddRange(validManufacturers);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //XML Import
        public static string ImportShells(ArtilleryContext context, string xmlString)
        {
            //Deserializing the XML to Shell DTOs
            XmlHelper xmlHelper = new XmlHelper();
            ImportShellDto[] shellDtos = xmlHelper.Deserialize<ImportShellDto[]>(xmlString, "Shells");

            //Selecting only the Valid Shells
            HashSet<Shell> validShells = new HashSet<Shell>();
            StringBuilder sb = new StringBuilder();

            foreach (var shellDto in shellDtos)
            {
                //Invalid Shell
                if (!IsValid(shellDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Shell
                validShells.Add(new Shell()
                {
                    ShellWeight = shellDto.ShellWeight,
                    Caliber = shellDto.Caliber
                });
                sb.AppendLine(String.Format(SuccessfulImportShell, shellDto.Caliber, shellDto.ShellWeight));
            }
            //Adding and Saving
            context.Shells.AddRange(validShells);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //JSON Import
        public static string ImportGuns(ArtilleryContext context, string jsonString)
        {
            //Deserializing the JSON to Gun DTOs
            ImportGunDto[] gunDtos = JsonConvert.DeserializeObject<ImportGunDto[]>(jsonString);

            //Selecting only the Valid Guns
            HashSet<Gun> validGuns = new HashSet<Gun>();
            StringBuilder sb = new StringBuilder();

            foreach (var gunDto in gunDtos)
            {
                //Invalid Gun
                if (!IsValid(gunDto) || !Enum.TryParse(gunDto.GunType, out GunType gunType))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Gun
                Gun validGun = new Gun()
                {
                    ManufacturerId = gunDto.ManufacturerId,
                    GunWeight = gunDto.GunWeight,
                    BarrelLength = gunDto.BarrelLength,
                    NumberBuild = gunDto.NumberBuild,
                    Range = gunDto.Range,
                    GunType = gunType,
                    ShellId = gunDto.ShellId
                };
                //Selecting only the unique Contry Ids
                foreach (var country in gunDto.Countries.DistinctBy(c => c.Id))
                {
                    validGun.CountriesGuns.Add(new CountryGun()
                    {
                        CountryId = country.Id
                    });
                }
                validGuns.Add(validGun);
                sb.AppendLine(String.Format(SuccessfulImportGun, gunDto.GunType.ToString(), gunDto.GunWeight, gunDto.BarrelLength));
            }
            //Adding and Saving
            context.Guns.AddRange(validGuns);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }
        
        //DTOs Validation
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}