using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var counts = new Dictionary<string, int>();

            string[] words = Console.ReadLine().Split();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;
                }
                else
                {
                    counts.Add(wordInLowerCase, 1);
                }
            }

            foreach (var count in counts)
            {
                if(count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
