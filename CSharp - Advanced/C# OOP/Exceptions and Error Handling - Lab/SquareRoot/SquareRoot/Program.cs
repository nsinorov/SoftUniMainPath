
try
{
    int number = int.Parse(Console.ReadLine());

    if (number < 0)
    {
        Console.WriteLine("Invalid number.");
    }
    else
    {
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine(squareRoot);
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid input.");
}
finally
{
    Console.WriteLine("Goodbye.");
}