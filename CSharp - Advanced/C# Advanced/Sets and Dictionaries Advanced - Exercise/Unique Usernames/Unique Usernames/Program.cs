int numOfInput = int.Parse(Console.ReadLine());

HashSet<string> names = new();

for (int i = 0; i < numOfInput; i++)
{

    string name = Console.ReadLine();
    names.Add(name);


}

foreach (var name in names)
{
    Console.WriteLine(name);
}