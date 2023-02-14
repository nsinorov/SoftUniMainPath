var input = Console.ReadLine();

HashSet<string> parking = new();

while(input != "END")
{
    string[] tokens = input.Split(", ");
    string command = tokens[0];
    string carPlate = tokens[1];

    if (command == "IN")
    {
        parking.Add(carPlate);
    }
    else
    {
        parking.Remove(carPlate);
    }

    input = Console.ReadLine();
}

if(parking.Count > 0)
{
    foreach (var car in parking)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}