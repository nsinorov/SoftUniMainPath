using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EDriveRent.Repositories;
public class VehicleRepository : IRepository<IVehicle>
{
    private readonly List<IVehicle> vehicles;
    public VehicleRepository()
    {
        vehicles = new List<IVehicle>();
    }
    public void AddModel(IVehicle model) => vehicles.Add(model);

    public IVehicle FindById(string identifier)
    {
        return vehicles.FirstOrDefault(m => m.LicensePlateNumber == identifier);
    }

    public IReadOnlyCollection<IVehicle> GetAll() => vehicles;

    public bool RemoveById(string identifier)
    {
        IVehicle vehicle = vehicles.FirstOrDefault(r => r.LicensePlateNumber == identifier);

        if (vehicle == null)
        {
            
            return false;
        }
        vehicles.Remove(vehicle);
        return true;
    }
}
