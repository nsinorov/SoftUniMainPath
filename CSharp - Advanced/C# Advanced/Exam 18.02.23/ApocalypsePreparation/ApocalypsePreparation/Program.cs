// Reading the input
Queue<int> textile = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Stack<int> medicaments = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Dictionary<int, string> resources = new()
{
    { 30, "Patch" },
    { 40, "Bandage" },
    { 100, "MedKit" }
};

Dictionary<string, int> itemAndAmount = new();

//Logic
while (textile.Count != 0 && medicaments.Count != 0)
{
    int firstTextile = textile.Peek();
    int lastMedicament = medicaments.Peek();
    int mixSum = firstTextile + lastMedicament;

    if (resources.ContainsKey(mixSum))
    {
        string item = resources[mixSum];

        if (!itemAndAmount.ContainsKey(item))
        {
            itemAndAmount.Add(item, 0);
        }

        itemAndAmount[item]++;

        medicaments.Pop();
    }

    else if (!resources.ContainsKey(mixSum))
    {
        if (mixSum > 100)
        {
            if (!itemAndAmount.ContainsKey("MedKit"))
            {
                itemAndAmount.Add("MedKit", 0);
            }

            itemAndAmount["MedKit"]++;

            medicaments.Pop();

            int resourcesLeft = mixSum - 100;

            medicaments.Push(medicaments.Pop() + resourcesLeft);
        }
        else
        {
            int saveMedicament = medicaments.Pop() + 10;
            medicaments.Push(saveMedicament);
        }
    }

    textile.Dequeue();
}

//Output
if (textile.Count == 0 && medicaments.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textile.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else if (!medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}

if (itemAndAmount.Any())
{
    foreach (var item in itemAndAmount
        .OrderByDescending(i => i.Value)
        .ThenBy(i => i.Key))
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}

if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}

if (textile.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textile)}");
}