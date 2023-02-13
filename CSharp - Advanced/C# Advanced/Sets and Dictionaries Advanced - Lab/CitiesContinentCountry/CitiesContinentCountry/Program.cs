using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics;

int numOfInputs = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> continents = new();

for (int i = 0; i < numOfInputs; i++)
{

    string input = Console.ReadLine();

    string[] spilitted = input.Split();
    string continent = spilitted[0];
    string country = spilitted[1];
    string city = spilitted[2];

    if (!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!continents[continent].ContainsKey(country))
    {
        continents[continent].Add(country, new List<string>());
    }
    continents[continent][country].Add(city);

}

foreach (var continent in continents)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var country in continent.Value)
    {
        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
    }
}

