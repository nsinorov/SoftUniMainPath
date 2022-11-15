using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = tokens[0];
                var employeeID = tokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());

                }

                if (companies[companyName].Contains(employeeID))
                {
                    command = Console.ReadLine();
                    continue;
                }
                   
                companies[companyName].Add(employeeID);

                command = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employeeID in company.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
