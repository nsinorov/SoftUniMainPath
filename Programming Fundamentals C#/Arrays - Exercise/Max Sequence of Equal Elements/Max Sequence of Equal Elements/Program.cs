using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 1;
            int theMost = 0;
            int element = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > theMost)
                {
                    theMost = counter;
                    element = numbers[i];
                }
            }
            for (int j = 1; j <= theMost; j++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}

