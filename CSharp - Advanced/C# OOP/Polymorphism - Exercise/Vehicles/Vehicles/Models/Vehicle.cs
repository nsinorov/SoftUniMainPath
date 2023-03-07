namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumptionInLitersPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionInLitersPerKm = fuelConsumptionInLitersPerKm;
        }

        public double FuelQuantity { get; set; }

        public virtual double FuelConsumptionInLitersPerKm { get; set; }

        public bool CanDrive(double km) => FuelQuantity - km * FuelConsumptionInLitersPerKm >= 0;

        public virtual void Drive(double km)
        {
            if (CanDrive(km))
            {
                FuelQuantity -= km * FuelConsumptionInLitersPerKm;
            }
        }

        public virtual void Refuel(double amount) => FuelQuantity += amount;

    }
}
