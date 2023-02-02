
using System.Reflection;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
          Car car = new Car();
          
          car.Make = "MK3";
          car.Model = "VW";
          car.Year = 1992;
          car.FuelQuantity = 200;
          car.FuelConsumption= 200;
          car.Drive(200);
          
          Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
          
          Console.WriteLine(car.WhoAmI());

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(car.Make, car.Model, car.Year);
            Car thirdCar = new Car(car.Make, car.Model, car.Year, car.FuelQuantity, car.FuelConsumption);


            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3)
            };

            var engine = new Engine(560, 6300);

            var vehicle = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

        }
    }
}
