using System;
using System.Linq;
using System.Collections.Generic;

namespace Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.RemoveAll(x => x < 0);
            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));

            if (numbers.Count == 0 || numbers.Count < 0)
            {
                Console.Write("empty");
            }
           
        }
    }
}
