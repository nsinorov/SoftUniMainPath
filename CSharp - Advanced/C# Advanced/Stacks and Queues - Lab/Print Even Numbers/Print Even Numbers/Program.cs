
int[] arrayOfNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> queue = new Queue<int>();

foreach (int num in arrayOfNums)
{
    queue.Enqueue(num);
}

bool first = true;

while (queue.Count > 0)
{
    int num = queue.Dequeue();

    if (num % 2 == 0)
    {
        if (!first)
        {
            Console.Write(", ");
        }
        Console.Write(num);
        first = false;
    }
}

 