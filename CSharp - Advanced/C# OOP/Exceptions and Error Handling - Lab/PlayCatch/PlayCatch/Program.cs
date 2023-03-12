List<int> arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

int exceptionsCount = 0;

while (exceptionsCount < 3)
{
    string[] command = Console.ReadLine().Split();

    try
    {
        if (command[0] == "Replace")
        {
            int index = int.Parse(command[1]);
            int element = int.Parse(command[2]);
            arr[index] = element;
        }
        else if (command[0] == "Print")
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);
            PrintArrayRange(arr, startIndex, endIndex);
        }
        else if (command[0] == "Show")
        {
            int index = int.Parse(command[1]);
            Console.WriteLine(ShowElement(arr, index));
        }
        else
        {
            throw new Exception("Invalid command!");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("The variable is not in the correct format!");
        exceptionsCount++;
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("The index does not exist!");
        exceptionsCount++;
    }
    catch (Exception)
    {
        Console.WriteLine("The index does not exist!");
        exceptionsCount++;
    }
}

Console.WriteLine(string.Join(", ", arr));

static void PrintArrayRange(List<int> arr, int startIndex, int endIndex)
{
    if (startIndex < 0 || startIndex >= arr.Count ||
        endIndex < 0 || endIndex >= arr.Count)
    {
        throw new IndexOutOfRangeException();
    }

    for (int i = startIndex; i <= endIndex; i++)
    {
        Console.Write(arr[i]);
        if (i != endIndex)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

static int ShowElement(List<int> arr, int index)
{
    if (index < 0 || index >= arr.Count)
    {
        throw new IndexOutOfRangeException();
    }

    return arr[index];
}