int durationOfGreenLight = int.Parse(Console.ReadLine());
int freeWindowSec = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

int passedCarsCounter = 0;

var queue = new Queue<string>();

while (command != "END")
{
    if (command == "green")
    {
        int greenLight = durationOfGreenLight;
        int freeWindow = freeWindowSec;

        while (queue.Any())
        {
            string currentCar = queue.Peek();

            if (greenLight >= currentCar.Length)
            {
                greenLight -= currentCar.Length;
                queue.Dequeue();
                passedCarsCounter++;
            }
            else if (greenLight <= 0)
            {
                break;
            }
            else if (greenLight < currentCar.Length)
            {
                if (greenLight + freeWindow >= currentCar.Length)
                {
                    greenLight = 0;
                    freeWindow -= currentCar.Length;
                    queue.Dequeue();
                    passedCarsCounter++;
                }
                else
                {
                    int indexOfCrash = greenLight + freeWindow;

                    if (indexOfCrash >= 0 && indexOfCrash < currentCar.Length)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {currentCar[indexOfCrash]}.");
                        return;
                    }
                }
            }
        }
    }
    else
    {
        queue.Enqueue(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedCarsCounter} total cars passed the crossroads.");
