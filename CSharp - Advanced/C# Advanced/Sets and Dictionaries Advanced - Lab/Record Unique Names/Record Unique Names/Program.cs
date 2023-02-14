int numsOfInput = int.Parse(Console.ReadLine());

HashSet<string> names = new HashSet<string>();

for (int i = 0; i < numsOfInput; i++)
{

    names.Add(Console.ReadLine());
}
foreach (var name in names)
{
    Console.WriteLine(name);
}
