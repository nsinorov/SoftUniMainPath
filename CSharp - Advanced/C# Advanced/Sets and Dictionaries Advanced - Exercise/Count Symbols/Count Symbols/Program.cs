string input = Console.ReadLine();

SortedDictionary<char, int> charsCount = new();

foreach (var ch in input)
{
    if (!charsCount.ContainsKey(ch))
    {
        charsCount.Add(ch, 0);
    }

    charsCount[ch]++;
}

foreach (var charCount in charsCount)
{
    Console.WriteLine($"{charCount.Key}: {charCount.Value} time/s");
}