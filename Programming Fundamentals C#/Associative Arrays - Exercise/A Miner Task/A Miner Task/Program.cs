using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var resource = new Dictionary<string, int>();

            while(input != "stop")
            {
                int currValue = int.Parse(Console.ReadLine());

                if (!resource.ContainsKey(input))
                {
                    resource.Add(input, 0);
                }
                resource[input] += currValue;

                input = Console.ReadLine();
            }

            foreach (var item in resource)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
