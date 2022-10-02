using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumForEven = 0;
            int sumForOdd = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];

                if (currNum % 2 == 0)
                {
                    sumForEven += currNum;
                }
                else
                {
                    sumForOdd += currNum;
                }
            }
            Console.Write($"{sumForEven - sumForOdd}");
        }
    }
}
