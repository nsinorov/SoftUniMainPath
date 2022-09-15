using System;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFishermens = int.Parse(Console.ReadLine());
            double totalSum = 0;

            switch (season)
            {
                case "Spring":

                    if (numOfFishermens <= 6)
                    {
                        double discount = 0.1;
                        totalSum = 3000 - (3000 * discount);
                    }
                    else if (numOfFishermens >= 7 && numOfFishermens <= 11)
                    {
                        double discount = 0.15;
                        totalSum = 3000 - (3000 * discount);
                    }
                    else if (numOfFishermens >= 12)
                    {
                        double discount = 0.25;
                        totalSum = 3000 - (3000 * discount);
                    }
                    break;

                case "Summer":
                case "Autumn":

                    if (numOfFishermens <= 6)
                    {
                        double discount = 0.1;
                        totalSum = 4200 - (4200 * discount);
                    }
                    else if (numOfFishermens <= 11)
                    {
                        double discount = 0.15;
                        totalSum = 4200 - (4200 * discount);

                    }
                    else if (numOfFishermens >= 12)
                    {
                        double discount = 0.25;
                        totalSum = 4200 - (4200 * discount);
                    }
                    break;

                case "Winter":

                    if (numOfFishermens <= 6)
                    {
                        double discount = 0.1;
                        totalSum = 2600 - (2600 * discount);
                    }
                    else if (numOfFishermens <= 11)
                    {
                        double discount = 0.15;
                        totalSum = 2600 - (2600 * discount);

                    }
                    else if (numOfFishermens >= 12)
                    {
                        double discount = 0.25;
                        totalSum = 2600 - (2600 * discount);
                    }
                    break;
                default:
                    break;
            }
            if ((numOfFishermens % 2 == 0) && (season != "Autumn"))
            {
                 totalSum = totalSum - (totalSum * 0.05);              
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"Yes! You have {budget - totalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:F2} leva.");
            }
        }
    }
}
