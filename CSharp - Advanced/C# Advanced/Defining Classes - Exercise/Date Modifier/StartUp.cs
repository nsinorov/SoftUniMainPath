using DefiningClasses;
using System;
using System.Collections.Immutable;

public class StartUp
{
    static void Main(string[] args)
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();

        int differenceInDays = DateModifier.GetDiffInDays(start, end);

        Console.WriteLine(differenceInDays);
    }
}