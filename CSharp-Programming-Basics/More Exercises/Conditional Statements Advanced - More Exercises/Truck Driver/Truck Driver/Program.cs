using System;

namespace Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string season = Console.ReadLine(); 
            double km = double.Parse(Console.ReadLine());

            double totalSum = 0;

            if (km <= 5000)
            {   
                if (season == "Spring" || season == "Autumn")
                {
                    totalSum = (km * 0.75) * 4;
                }
                else if (season == "Summer")
                {
                    totalSum = (km * 0.90) * 4;
                }
                else if(season == "Winter")
                {
                    totalSum = (km * 1.05) * 4;
                }
            }
            else if(5000 < km && km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    totalSum = (km * 0.95) * 4;
                }
                else if (season == "Summer")
                {
                    totalSum = (km * 1.10) * 4;
                }
                else if (season == "Winter")
                {
                    totalSum = (km * 1.25) * 4;
                }
            }
            else if(10000 < km && km <= 20000)
            {
                if (season == "Spring" || season == "Autumn" || season == "Summer" || season == "Winter")
                {
                    totalSum = (km * 1.45) * 4;
                }
            }

            totalSum = totalSum - (totalSum * 0.1);

            Console.WriteLine($"{totalSum:F2}");

        }
    }
}
