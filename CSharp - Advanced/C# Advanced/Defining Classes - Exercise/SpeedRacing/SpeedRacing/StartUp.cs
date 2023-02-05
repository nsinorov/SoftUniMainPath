using SpeedRacing;
public class Startup
{
    static void Main(string[] args)
    {
        int numOfCars = int.Parse(Console.ReadLine());

        Dictionary<string, Car> carsByNames = new();

        for (int i = 0; i < numOfCars; i++)
        {

            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new()
            {
                Model = carInfo[0],
                FuelAmount = double.Parse(carInfo[1]),
                FuelConsumptionPerKilometer = double.Parse(carInfo[2])
            };

            carsByNames.Add(car.Model, car);
        }
        string command = Console.ReadLine();
        while (command != "End")
        {
            string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string carModel = tokens[1];
            double amountOfKilometers = double.Parse(tokens[2]);

            Car car = carsByNames[carModel];

            car.Drive(amountOfKilometers);

            command = Console.ReadLine();
        }

        foreach (var car in carsByNames.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }
    }
}