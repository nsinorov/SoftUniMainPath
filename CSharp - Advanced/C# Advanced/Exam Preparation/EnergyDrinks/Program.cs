Stack<int> caffeineMiligrams = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> energyDrinks = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int totalCaffeine = 0;

while(caffeineMiligrams.Count > 0 && energyDrinks.Count > 0)
{
    int lastCaffein = caffeineMiligrams.Pop();
    int firstDrink = energyDrinks.Dequeue();
    int multiplication = lastCaffein * firstDrink;

    if(totalCaffeine + multiplication <= 300)
    {
        totalCaffeine += multiplication;
    }
    else
    {
        energyDrinks.Enqueue(firstDrink);
        totalCaffeine -= 30;

        if(totalCaffeine < 0)
        {
            totalCaffeine = 0;
        }
    }
}

if(energyDrinks.Count > 0)
{
    Console.WriteLine($"Drinks left: {String.Join(", ", energyDrinks)}");
}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");