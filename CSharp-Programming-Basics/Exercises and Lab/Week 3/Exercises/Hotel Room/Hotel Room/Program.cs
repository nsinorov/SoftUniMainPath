using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double priceForStudio = 0.00;
            double priceForAp = 0.00;

            switch (month)
            {
                case "May":
                case "October":

                    if (days > 7 && days <= 14)
                    {
                        priceForAp = 65;
                        priceForStudio = 50 - (50 * 0.05);

                    }

                 else if (days > 14)
                    {
                        priceForAp = 65;
                        priceForStudio = 50 - (50 * 0.3);
                    }

                    break;

                case "June":
                case "September":

                    if (days > 14)
                    {
                        priceForAp = 68.70;
                        priceForStudio = 75.20 - (75.20 * 0.2);

                    }
                    else if (days <= 14)
                    {
                        priceForAp = 68.70;
                        priceForStudio = 75.20;
                    }
                    break;

                case "July":
                case "August":

                    priceForAp = 77;
                    priceForStudio = 76;

                    break;              

            }

            double totalPriceForAp = priceForAp * days;
            double totalPricecForStudio = priceForStudio * days;

            if (days > 14)
            {

                totalPriceForAp -= totalPriceForAp * 0.1;

                Console.WriteLine($"Apartment: {totalPriceForAp:F2} lv.");
                Console.WriteLine($"Studio: {totalPricecForStudio:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Apartment: {totalPriceForAp:F2} lv.");
                Console.WriteLine($"Studio: {totalPricecForStudio:F2} lv.");
            }
        }
    }
}
