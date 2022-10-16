using System;
using System.Linq;
using System.Collections.Generic;

namespace Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

          int n = Math.Min(numbers1.Count, numbers2.Count);

            for (int i = 0; i < n; i++)
            {
                result.Add(numbers1[i]);
                result.Add(numbers2[i]);

            }

            if(numbers1.Count > numbers2.Count)
            {
                for (int i = n; i < numbers1.Count; i++)
                {
                    result.Add(numbers1[i]);              
                }
            }

            else if(numbers1.Count < numbers2.Count)
            {
                for (int i = n; i < numbers2.Count; i++)
                {
                    result.Add(numbers2[i]);            
                }
            }        
            Console.Write(string.Join(" ", result));
        }
    }
}
