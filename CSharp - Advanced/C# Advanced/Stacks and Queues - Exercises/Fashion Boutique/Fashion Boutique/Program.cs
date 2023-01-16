

Stack<int> clothesInBox = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

int capacityOfRack = int.Parse(Console.ReadLine());

int currentRack = capacityOfRack;
int numberOfRacks = 1;

while (clothesInBox.Any())
{
    currentRack -= clothesInBox.Peek();

    if(currentRack < 0)
    {
        currentRack = capacityOfRack;
        numberOfRacks++;

        continue;
    }
    clothesInBox.Pop();  
}
Console.WriteLine(numberOfRacks);