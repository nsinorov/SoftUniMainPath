using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = nums.Length;
             
            while(count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }
                count--;                     
            }
            Console.WriteLine(nums[0]);
        }
    }
}
