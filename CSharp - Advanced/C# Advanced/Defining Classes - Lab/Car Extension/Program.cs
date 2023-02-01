
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
        }
    }
}
