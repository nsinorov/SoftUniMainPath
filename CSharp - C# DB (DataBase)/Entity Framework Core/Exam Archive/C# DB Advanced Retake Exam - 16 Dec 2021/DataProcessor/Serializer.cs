
namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.DataProcessor.ExportDto;
    using Artillery.Utilities;
    using Newtonsoft.Json;

    public class Serializer
    {
        //JSON Export
        public static string ExportShells(ArtilleryContext context, double shellWeight)
        {
            //Selecting the Shells
            var shells = context.Shells
                .AsEnumerable()
                .Where(s => s.ShellWeight > shellWeight)
                .Select(s => new
                {
                    ShellWeight = s.ShellWeight,
                    Caliber = s.Caliber,
                    Guns = s.Guns
                    .Where(g => g.GunType.ToString() == "AntiAircraftGun")
                    .Select(g => new
                    {
                        GunType = g.GunType.ToString(),
                        GunWeight = g.GunWeight,
                        BarrelLength = g.BarrelLength,
                        Range = g.Range > 3000 ? "Long-range" : "Regular range"
                    })
                    .OrderByDescending(g => g.GunWeight)
                    .ToArray()
                })
                .OrderBy(s => s.ShellWeight)
                .ToArray();

            //Result as JSON
            return JsonConvert.SerializeObject(shells, Formatting.Indented);
        }

        //XML Export
        public static string ExportGuns(ArtilleryContext context, string manufacturer)
        {
            //Selecting the Guns
            var guns = context.Guns
                .AsEnumerable()
                .Where(g => g.Manufacturer.ManufacturerName == manufacturer)
                .Select(g => new ExportGunDto()
                {
                    Manufacturer = g.Manufacturer.ManufacturerName,
                    GunType = g.GunType.ToString(),
                    GunWeight = g.GunWeight,
                    BarrelLength = g.BarrelLength,
                    Range = g.Range,
                    Countries = g.CountriesGuns
                    .Where(cg => cg.Country.ArmySize > 4500000)
                    .Select(cg => new ExportCountryDto()
                    {
                        Country = cg.Country.CountryName,
                        ArmySize = cg.Country.ArmySize
                    })
                    .OrderBy(c => c.ArmySize)
                    .ToArray()
                })
                .OrderBy(g => g.BarrelLength)
                .ToArray();

            //Result as XML
            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize<ExportGunDto[]>(guns, "Guns");
        }
    }
}
