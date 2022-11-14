using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            var synonims = new Dictionary<string, List<string>>();

            int countOfWords = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!synonims.ContainsKey(word))
                {
                    synonims.Add(word, new List<string>());
                }
                synonims[word].Add(synonim);
            }

            foreach (var item in synonims)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
