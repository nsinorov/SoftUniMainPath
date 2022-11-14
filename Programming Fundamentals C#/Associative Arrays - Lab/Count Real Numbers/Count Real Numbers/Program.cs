using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            var numOfOcc = new SortedDictionary<double, int>();

            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var num in nums)
            {          
                if (!numOfOcc.ContainsKey(num))
                {
                     numOfOcc.Add(num, 0);   
                }
                numOfOcc[num] += 1;
            }
   
            foreach (var item in numOfOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
