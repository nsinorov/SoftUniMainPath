using RawData;
public class Startup
{
    static void Main(string[] args)
    {
        int numOfCars = int.Parse(Console.ReadLine());

        List<Car> cars = new();

        for (int i = 0; i < numOfCars; i++)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new(
                carInfo[0],
                int.Parse(carInfo[1]),
                int.Parse(carInfo[2]),
                 int.Parse(carInfo[3]),
                carInfo[4],
                double.Parse(carInfo[5]),
                int.Parse(carInfo[6]),
                double.Parse(carInfo[7]),
                int.Parse(carInfo[8]),
                double.Parse(carInfo[9]),
                int.Parse(carInfo[10]),
                double.Parse(carInfo[11]),
                int.Parse(carInfo[12])
                );
            cars.Add(car);
        }

        string command = Console.ReadLine();

        string[] filteredModels;

        if (command == "fragile")
        {
            filteredModels = cars.Where(c => c.Cargo.Type == "fragile" && c.Tyres.Any(t => t.Pressure < 1)).Select(c => c.Model).ToArray();

        }
        else
        {
            filteredModels = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).Select(c => c.Model).ToArray();
        }

        Console.WriteLine(string.Join(Environment.NewLine, filteredModels));
    }
}