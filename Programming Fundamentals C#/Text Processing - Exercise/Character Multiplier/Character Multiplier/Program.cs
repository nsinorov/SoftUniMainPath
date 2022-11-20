using System;

namespace Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            GetStringSum(input[0], input[1]);
        }
        private static void GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLenght = Math.Min(stringOne.Length, stringTwo.Length);
            for (int i = 0; i < minLenght; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string longestString = stringOne;
            if (longestString.Length < stringTwo.Length)
            {
                longestString = stringTwo;
            }
            for (int i = minLenght; i < longestString.Length; i++)
            {
                sum += longestString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
