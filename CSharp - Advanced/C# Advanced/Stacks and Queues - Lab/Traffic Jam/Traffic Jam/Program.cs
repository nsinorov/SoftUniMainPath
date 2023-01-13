int numOfCars = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
Queue<string> queue = new Queue<string>();
int count = 0;

while(command != "end")
{
    if(command == "green")
    {
        for (int i = 0; i < numOfCars; i++)
        {
            // check if there are cars
            if(queue.Count == 0)
            {
                break;
            }
            count++;
            Console.WriteLine($"{queue.Dequeue()} passed!");
        }
    }
    else
    {
        queue.Enqueue(command);
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{count} cars passed the crossroads.");