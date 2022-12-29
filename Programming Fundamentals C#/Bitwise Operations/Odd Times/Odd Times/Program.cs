using System;
using System.Linq;

namespace Odd_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result ^= numbers[i];
            }

            Console.WriteLine(result);
        }
    }
}
