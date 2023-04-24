using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleGarage
{
    public class Garage
    {
        public Garage(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity { get; set; }

        public List<Vehicle> Vehicles { get; set; }

        public bool AddVehicle(Vehicle vehicle)
        {
            if (this.Capacity == this.Vehicles.Count || 
                this.Vehicles.Any(v => v.LicensePlateNumber == vehicle.LicensePlateNumber))
            {
                return false;
            }

            Vehicles.Add(vehicle);
            return true;
        }

        public int ChargeVehicles(int batteryLevel)
        {
            int vehiclesCharged = 0;

            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.BatteryLevel <= batteryLevel)
                {
                    vehicle.BatteryLevel = 100;
                    vehiclesCharged++;
                }
            }

            return vehiclesCharged;
        }

        public void DriveVehicle(string licensePlateNumber, int batteryDrainage, bool accidentOccured)
        {
            Vehicle vehicle = this.Vehicles.Find(v => v.LicensePlateNumber == licensePlateNumber);

            if (vehicle.IsDamaged || 
                batteryDrainage > 100 || 
                vehicle.BatteryLevel < batteryDrainage)
            {
                return;
            }

            vehicle.BatteryLevel -= batteryDrainage;

            if (accidentOccured)
            {
                vehicle.IsDamaged = true;
            }
        }

        public string RepairVehicles()
        {
            int vehiclesRepaired = 0;

            foreach(Vehicle vehicle in Vehicles.Where(v => v.IsDamaged == true))
            {
                vehicle.IsDamaged = false;
                vehiclesRepaired++;
            }

            return $"Vehicles repaired: {vehiclesRepaired}";
        } 
    }
}
