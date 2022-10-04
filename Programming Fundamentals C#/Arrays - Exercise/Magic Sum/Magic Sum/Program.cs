using System;
using System.Linq;

namespace Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumNum = int.Parse(Console.ReadLine());
        
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 1 + i; j < input.Length; j++)
                {
                    if (input[i] + input[j] == sumNum)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                    }
                }      
            }
        }
    }
}
