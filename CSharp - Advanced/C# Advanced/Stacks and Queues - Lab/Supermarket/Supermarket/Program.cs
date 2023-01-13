
Queue<string> queue = new Queue<string>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "Paid")
    {      
        while (queue.Any())
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
    else if (input == "End")
    {
        Console.WriteLine($"{queue.Count} people remaining.");
        break;
    }
    else
    {
        queue.Enqueue(input);
    }
}
