using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<string> List1 = Console.ReadLine().Split(" | ").ToList();
                var wordDataBase = new Dictionary<string, List<string>>();
                List<string> word = Console.ReadLine().Split(" | ").ToList();
                string inputCommand = Console.ReadLine();
                List<string> alpabet = new List<string>();
                int b;
                for (int i = 0; i < List1.Count; i++)
                {

                    alpabet = List1[i].Split(": ").ToList();
                    if (wordDataBase.ContainsKey(alpabet[0]) == false)
                    {
                        wordDataBase.Add(alpabet[0], new List<string>());
                    }
                    for (b = 1; b < alpabet.Count; b++)
                    {

                        wordDataBase[alpabet[0]].Add(alpabet[b]);
                    }

                    alpabet.Clear();
                }

                if (inputCommand == "Test")
                {
                    foreach (var item in word)
                    {
                        if (wordDataBase.ContainsKey(item))
                        {
                            Console.WriteLine($"{item}:");
                            var li = wordDataBase[item];
                            foreach (var wo in li)
                            {
                                Console.WriteLine($" -{wo}");
                            }
                        }
                    }
                }
                else if (inputCommand == "Hand Over")
                {
                    var keys = wordDataBase.Keys;
                    Console.WriteLine(string.Join(' ', keys));
                }
            }
        }
    }
}