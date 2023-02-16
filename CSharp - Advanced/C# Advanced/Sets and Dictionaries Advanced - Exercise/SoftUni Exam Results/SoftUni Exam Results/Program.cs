SortedDictionary<string, int> participantsPoints = new();
SortedDictionary<string, int> languagesSubmissions = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "exam finished")
{
    string[] tokens = command.Split("-", StringSplitOptions.RemoveEmptyEntries);

    string name = tokens[0];

    if (tokens[1] == "banned")
    {
        participantsPoints.Remove(name);
        continue;
    }

    string language = tokens[1];
    int points = int.Parse(tokens[2]);

    if (!participantsPoints.ContainsKey(name))
    {
        participantsPoints.Add(name, default);
    }

    if (participantsPoints[name] < points)
    {
        participantsPoints[name] = points;
    }

    if (!languagesSubmissions.ContainsKey(language))
    {
        languagesSubmissions.Add(language, default);
    }

    languagesSubmissions[language]++;
}

Console.WriteLine("Results:");

foreach (var participantPoint in participantsPoints.OrderByDescending(p => p.Value))
{
    Console.WriteLine($"{participantPoint.Key} | {participantPoint.Value}");
}

Console.WriteLine("Submissions:");

foreach (var languageSubmission in languagesSubmissions.OrderByDescending(l => l.Value))
{
    Console.WriteLine($"{languageSubmission.Key} - {languageSubmission.Value}");
}