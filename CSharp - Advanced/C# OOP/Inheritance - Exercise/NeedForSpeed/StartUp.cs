using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sportCar = new(200, 20);

            sportCar.Drive(5);

            Console.WriteLine(sportCar.Fuel);
            Console.WriteLine(sportCar.HorsePower);
            Console.WriteLine(sportCar.FuelConsumption);

            Motorcycle motor = new(150, 40);

            motor.Drive(5);
            Console.WriteLine(motor.Fuel);
            Console.WriteLine(motor.HorsePower);
            Console.WriteLine(motor.FuelConsumption);
        }
    }
}
