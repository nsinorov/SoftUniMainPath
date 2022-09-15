using System;

namespace Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string car = string.Empty;
            string category = string.Empty;

            double totalSum = 0;

            if (budget <= 100)
            {
               category = "Economy class";
                
                if(season == "Summer")
                {
                    car = "Cabrio";
                    totalSum = 0.35 * budget;
                }
                else if(season == "Winter")
                {
                    car = "Jeep";
                    totalSum = 0.65 * budget;

                }
            }

            if(budget > 100 && budget <= 500)
            {
                category = "Compact class";

                if (season == "Summer")
                {
                    car = "Cabrio";
                    totalSum = 0.45 * budget;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    totalSum = 0.80 * budget;

                }
            }

            if(budget > 500)
            {
                category = "Luxury class";

                if(season == "Summer" || season == "Winter")
                {
                    car = "Jeep";
                    totalSum = 0.9 * budget;
                }
            }

            Console.WriteLine(category);
            Console.WriteLine($"{car} - {totalSum:F2}");
        }
    }
}
