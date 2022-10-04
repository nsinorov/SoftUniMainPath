using System;
using System.Linq;

namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                bool currNumIsBigger = true;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if(input[i] <= input[j])
                    {
                        currNumIsBigger = false;
                        break;
                    }
                }
                if (currNumIsBigger)
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}
