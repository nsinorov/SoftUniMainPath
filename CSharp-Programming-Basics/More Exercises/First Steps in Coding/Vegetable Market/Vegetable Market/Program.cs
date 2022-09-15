using System;

namespace Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForKiloVeg = double.Parse(Console.ReadLine());
            double priceForKiloFruits = double.Parse(Console.ReadLine());
            double totalKiloVeg = double.Parse(Console.ReadLine());
            double totalKiloFruit = double.Parse(Console.ReadLine());

            double priceVeg = priceForKiloVeg * totalKiloVeg;
            double priceFruits = priceForKiloFruits * totalKiloFruit;

            double totalBGN = priceVeg + priceFruits;

            double totalEu = totalBGN / 1.94;
         
            Console.WriteLine($"{totalEu:F2}");
        }
    }
}
