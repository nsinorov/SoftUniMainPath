namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fueConsumptionInLitersPerKm)
            : base(fuelQuantity, fueConsumptionInLitersPerKm)
        {
        }

        public override double FuelConsumptionInLitersPerKm
            => base.FuelConsumptionInLitersPerKm + 1.6;

        public override void Refuel(double amount)
        {
            amount *= 0.95;
            base.Refuel(amount);
        }
    }
}
