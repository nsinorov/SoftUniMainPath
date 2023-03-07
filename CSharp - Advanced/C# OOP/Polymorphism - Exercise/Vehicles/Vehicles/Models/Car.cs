namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fueConsumptionInLitersPerKm) : base(fuelQuantity, fueConsumptionInLitersPerKm)
        {
        }

        public override double FuelConsumptionInLitersPerKm => base.FuelConsumptionInLitersPerKm + 0.9;
        public override void Drive(double km)
        {
            base.Drive(km);
        }
    }
}
