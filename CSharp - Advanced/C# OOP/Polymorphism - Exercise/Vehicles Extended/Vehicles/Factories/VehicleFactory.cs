using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Factories.Interfaces;
using Vehicles.Models.Interfaces;
using Vehicles.Models;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle Create(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            switch (type)
            {
                case "Car":
                    return new Car(fuelQuantity, fuelConsumption, tankCapacity);
                case "Truck":
                    return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                case "Bus":
                    return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
