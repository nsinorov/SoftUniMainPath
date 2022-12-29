using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regular_ExpressionsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> finalFurnitures = new List<string>();
            double totalSum = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Purchase")
                {
                    break;
                }

                string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<amount>\d+)";



                Match furnitures = Regex.Match(command, pattern, RegexOptions.IgnoreCase);

                var nameFurniture = furnitures.Groups["furniture"].Value;
                var priceFurniture = furnitures.Groups["price"].Value;
                var amountFurniture = furnitures.Groups["amount"].Value;

                if (furnitures.Success)
                {
                    totalSum += double.Parse(priceFurniture) * double.Parse(amountFurniture);
                    finalFurnitures.Add(nameFurniture);
                }

            }

            Console.WriteLine("Bought furniture:");

            for (int i = 0; i < finalFurnitures.Count; i++)
            {
                Console.WriteLine(finalFurnitures[i]);
            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}