using System;

namespace T08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); // => [ A12b, s17G]
            double sum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0]; // A
                char lastLetter = item[^1]; // this is the same as item.length - 1 ==> b

                string numAsAString = item[1..^1]; // this will give us everything that's between 0 and the last index; => 12
                double numFromString = double.Parse(numAsAString); //12
                if (char.IsUpper(firstLetter))
                {
                    int postionOfTheLetter = firstLetter - 64;
                    numFromString /= postionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numFromString *= positionOfTheLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numFromString += positionOfTheLetter;
                }
                sum += numFromString;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}