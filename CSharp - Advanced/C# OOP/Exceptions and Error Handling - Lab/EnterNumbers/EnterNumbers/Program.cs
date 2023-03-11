int[] numbers = new int[10];
int start = 1;
int end = 100;

for (int i = 0; i < numbers.Length; i++)
{
    try
    {
        numbers[i] = ReadNumber(start, end);
        start = numbers[i];
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
        i--;
    }
    catch (ArgumentOutOfRangeException e)
    {
        Console.WriteLine(e.Message);
        i--;
    }
}

Console.WriteLine(string.Join(", ", numbers));
    
    static int ReadNumber(int start, int end)
{
    int number = int.Parse(Console.ReadLine());

    if (number <= start || number >= end)
    {
        throw new ArgumentOutOfRangeException("", $"Your number is not in range {start} - {end}!");
    }
    return number;
}