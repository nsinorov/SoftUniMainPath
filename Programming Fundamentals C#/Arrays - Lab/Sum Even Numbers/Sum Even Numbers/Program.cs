using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];
                if(currNum % 2 == 0)
                {
                    sum += currNum;
                }             
            }
            Console.Write(sum);
        }
    }
}
