
Dictionary<string, int> peaks = new()
{
    {"Vihren", 80 },
     {"Kutelo", 90 },
     {"Banski Suhodol", 100 },
     {"Polezhan", 60 },
     {"Kamenitza", 70 }
};

Queue<string> peakNames = new(new List<string> { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" });

List<string> conqueredPeaks = new() { };

Stack<int> foodPortions = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> dailyStaminas = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

while(foodPortions.Any() && dailyStaminas.Any() && peakNames.Any())
{
    int foodPortion = foodPortions.Pop();
    int dailyStamina = dailyStaminas.Dequeue();
    int peakDifficulty = peaks[peakNames.Peek()];

    if(foodPortion + dailyStamina >= peakDifficulty)
    {
        conqueredPeaks.Add(peakNames.Dequeue());
    }
}

if (peakNames.Any())
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
else
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}

if (conqueredPeaks.Any())
{
    Console.WriteLine("Conquered peaks:");

    foreach (var peak in conqueredPeaks)
    {
        Console.WriteLine(peak);
    }
}