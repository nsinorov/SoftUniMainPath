int numOfInputs = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> clothingColor = new();

for (int i = 0; i < numOfInputs; i++)
{
    string[] tokens = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

    string color = tokens[0];

    if (!clothingColor.ContainsKey(color))
    {
        clothingColor[color] = new Dictionary<string, int>();
    }

    for (int j = 1; j < tokens.Length; j++)
    {
        string currentCloth = tokens[j];

        if (!clothingColor[color].ContainsKey(currentCloth))
        {
            clothingColor[color].Add(currentCloth, 0);
        }

        clothingColor[color][currentCloth]++;
    }
}

string[] desiredCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var clothByColor in clothingColor)
{
    Console.WriteLine($"{clothByColor.Key} clothes:");

    foreach (var cloth in clothByColor.Value)
    {
        string printItem = $"* {cloth.Key} - {cloth.Value}";

        if (clothByColor.Key == desiredCloth[0] && cloth.Key == desiredCloth[1])
        {
            printItem += " (found!)";
        }

        Console.WriteLine(printItem);
    }
}