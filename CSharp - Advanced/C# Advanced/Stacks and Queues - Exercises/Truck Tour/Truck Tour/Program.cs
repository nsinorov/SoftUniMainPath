const int litersPerKilometer = 1;
int numOfPetrolPumps = int.Parse(Console.ReadLine());

Queue<int[]> pumps = new();

for (int i = 0; i < numOfPetrolPumps; i++)
{
    int[] information = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    pumps.Enqueue(information);
}

int startIndex = 0;

while (true)
{
    bool isComplete = true;
    int totalLiters = 0;

    foreach (var pump in pumps)
    {
        int liters = pump[0];
        int distance = pump[1];

        totalLiters += liters;

        if (totalLiters - distance * litersPerKilometer < 0)
        {
            startIndex++;

            int[] currentPump = pumps.Dequeue();
            pumps.Enqueue(currentPump);

            isComplete = false;

            break;
        }

        totalLiters -= distance * litersPerKilometer;
    }

    if (isComplete)
    {
        Console.WriteLine(startIndex);
        break;
    }
}