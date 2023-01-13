string[] children = Console.ReadLine().Split();
Queue<string> queue = new Queue<string>(children);
int tosses = int.Parse(Console.ReadLine());
int startToss = 1;

while (queue.Count != 1)
{
    string child = queue.Dequeue();
    if (startToss < tosses)
    {
        startToss++;
        queue.Enqueue(child);

    }
    else
    {
        Console.WriteLine($"Removed {child}");
        startToss = 1;
    }
}
Console.WriteLine($"Last is {queue.Dequeue()}");
