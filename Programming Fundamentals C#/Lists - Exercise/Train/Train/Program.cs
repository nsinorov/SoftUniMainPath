using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numsOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfAWagons = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
           
             while (command != "end")
             {
                string[] commands = command.Split();

                if (commands.Length == 2)
                {
                  int wagon = int.Parse(commands[1]);
                    numsOfWagons.Add(wagon);
                }
                else
                {
                    int passengers = int.Parse(commands[0]);
                    FindWagon(numsOfWagons, maxCapacityOfAWagons, passengers);
                }            
                command = Console.ReadLine();
             }
            Console.WriteLine(string.Join(" ", numsOfWagons));
        }
        private static void FindWagon(List<int> numsOfWagons, int maxCapacityOfAWagons, int passengers)
        {
            for (int i = 0; i < numsOfWagons.Count; i++)
            {
                int currWagon = numsOfWagons[i];

                if(currWagon + passengers <= maxCapacityOfAWagons)
                {
                    numsOfWagons[i] += passengers;
                    break;
                }
            }
        }
    }
}
