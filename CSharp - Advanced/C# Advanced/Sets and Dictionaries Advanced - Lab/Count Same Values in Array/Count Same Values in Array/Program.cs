double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();   

Dictionary<double, int> occurences = new Dictionary<double, int>();

foreach (var number in numbers)
{
    if (!occurences.ContainsKey(number))
    {
        occurences.Add(number, 0);
    }

    occurences[number]++;
}

foreach (var item in occurences)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}