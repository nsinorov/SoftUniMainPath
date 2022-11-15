using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var final = new Dictionary<char, int>();

            foreach (var ch in text)
            {
                if (!final.ContainsKey(ch))
                {
                    final.Add(ch, 1);
                }
                else if (final.ContainsKey(ch))
                {
                    final[ch]++;
                }
            }

            foreach (KeyValuePair<char, int> ch in final.Where(a => a.Key != ' '))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
