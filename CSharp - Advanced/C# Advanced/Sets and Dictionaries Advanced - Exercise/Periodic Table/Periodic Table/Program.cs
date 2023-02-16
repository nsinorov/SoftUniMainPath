int numOfInputs = int.Parse(Console.ReadLine());

SortedSet<string> inputs = new();

for (int i = 0; i < numOfInputs; i++)
{
    string[] chemicalCompounds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    inputs.UnionWith(chemicalCompounds);
}

Console.Write(string.Join(" ", inputs));