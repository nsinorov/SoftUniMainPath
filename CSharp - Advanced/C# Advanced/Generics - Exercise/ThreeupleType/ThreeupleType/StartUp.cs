using ThreeupleType;

string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] drinkTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] bankInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Threeuple<string, string, string> person =
    new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));

Threeuple<string, int, bool> drinks =
    new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

Threeuple<string, double, string> bank =
    new(bankInfo[0], double.Parse(bankInfo[1]), bankInfo[2]);

Console.WriteLine(person);
Console.WriteLine(drinks);
Console.WriteLine(bank);