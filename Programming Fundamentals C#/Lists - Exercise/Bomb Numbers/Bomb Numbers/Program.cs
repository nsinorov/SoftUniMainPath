using System;
using System.Linq;
using System.Collections.Generic;

namespace Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] targetAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNum = targetAndPower[0];
            int power = targetAndPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int target = numbers[i];

                if(target == bombNum)
                {
                    BombNumbers(numbers, power, i);
                }
            }
            Console.WriteLine(numbers.Sum());
        }
        private static void BombNumbers(List<int> numbers, int power, int index)
        {       
            int start = Math.Max(0, index - power);
            int end = Math.Min(numbers.Count - 1, index + power);

            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
