using EqualityLogic;

HashSet<Person> hashSet = new();

SortedSet<Person> sortedSet = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person persom = new()
    {
        Name = personInfo[0],
        Age = int.Parse(personInfo[1]),
    };

    hashSet.Add(persom);
    sortedSet.Add(persom);

}

Console.WriteLine(hashSet.Count);
Console.WriteLine(sortedSet.Count);