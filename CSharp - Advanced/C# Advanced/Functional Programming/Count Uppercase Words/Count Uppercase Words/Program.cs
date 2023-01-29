Predicate<string> filterUpLetters = 
    f => f[0] == char.ToUpper(f[0]) && char.IsLetter(f[0]);

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(f => filterUpLetters(f)).ToArray();

foreach (var word in input)
{
    Console.WriteLine(word);
}