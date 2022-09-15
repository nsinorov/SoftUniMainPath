using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totalSum = 0;
            string place = string.Empty;
            string destination = string.Empty;

            if (budget <= 1000)
            {
                place = "Camp";

                if(season == "Summer")
                {
                    destination = "Alaska";
                    totalSum = 0.65 * budget;
                }
                else if(season == "Winter")
                {
                    destination = "Morocco";
                    totalSum = 0.45 * budget;
                }

            }

            else if(budget > 1000 && budget <= 3000)
            {
                place = "Hut";

                if (season == "Summer")
                {
                    destination = "Alaska";
                    totalSum = 0.80 * budget;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    totalSum = 0.60 * budget;
                }

            }

            else if(budget > 3000)
            {
                place = "Hotel";

                totalSum = 0.9 * budget;

                if(season == "Summer")
                {
                    destination = "Alaska";
                }

                else if(season == "Winter")
                {
                    destination = "Morocco";
                }
            }

            Console.WriteLine($"{destination} - {place} - {totalSum:F2}");

        }
    }
}
