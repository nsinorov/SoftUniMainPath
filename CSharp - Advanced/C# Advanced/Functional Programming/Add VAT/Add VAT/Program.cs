double[] prices = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

foreach (var nums in prices)
{
    Console.WriteLine($"{nums * 1.2 :f2}");
}
