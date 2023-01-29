Action<string[]> print = strings
    => Console.WriteLine(string.Join(Environment.NewLine, strings));

string[] name = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(name);