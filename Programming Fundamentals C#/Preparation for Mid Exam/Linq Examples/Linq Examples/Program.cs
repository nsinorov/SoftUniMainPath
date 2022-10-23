using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
                { 1,2,3,4,5,6,7,8,9, 10 };

            //numbers.Sum()
            Console.WriteLine(numbers.Sum());

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);

            //Min
            Console.WriteLine(numbers.Min());

            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            Console.WriteLine(minNumber);

            //Max
            Console.WriteLine(numbers.Max());

            //Average
            Console.WriteLine(numbers.Average());

            //Skip
            Console.WriteLine(string.Join(" ", numbers.Skip(2)));

            //Take
            Console.WriteLine(string.Join(" ", numbers.Take(2)));

            //OrderBy
            Console.WriteLine(string.Join(" ", numbers.OrderBy(x => x))); //.Sort

            //OrderByDesceding
            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x)));

            //Where
            Console.WriteLine(
                string.Join(" ", numbers.Where(x => x % 2 == 0)));

            Console.WriteLine(
                   string.Join(" ", numbers.Where(x => x % 2 != 0)));

            Console.WriteLine(
                   string.Join(" ", numbers.Where(x => x > 5)));

            //All
            Console.WriteLine(
                string.Join(" ", numbers.All(x => x > 0)));

            //Any
            Console.WriteLine(
                string.Join(" ", numbers.Any(x => x % 2 != 0)));

            //Select
            Console.WriteLine(
                string.Join(" ", numbers.Select(x => x / 2)));


        }
    }
}
