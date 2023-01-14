int[] tokens = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

var queue = new Queue<int>(nums);

int elementsToDeque = tokens[1];
int number = tokens[2];

for (int i = 0; i < elementsToDeque; i++)
{
    queue.Dequeue();
}

if (queue.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Any())
    {
        Console.WriteLine(queue.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}