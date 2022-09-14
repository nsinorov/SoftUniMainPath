using System;

namespace Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            double priceForVacation = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());

            double puzzlePrice = numPuzzles *2.60;
            int priceDoll = numDolls * 3;
            double priceBear = numBears * 4.10;
            double priceMinion = numMinions * 8.20;
            int priceTruck = numTrucks * 2;

            double totalQuantity = numPuzzles + numDolls + numBears + numMinions + numTrucks;

            double priceSum = puzzlePrice + priceDoll + priceBear + priceMinion + priceTruck;
            
            if (totalQuantity >= 50)
            {
                priceSum -= priceSum * 0.25;
            }
                priceSum -= priceSum * 0.1;

            if (priceSum >= priceForVacation)
            {
                priceSum -= priceForVacation;
                Console.WriteLine($"Yes! {priceSum:f2} lv left.");
            }
            else
            {
                priceForVacation -= priceSum;
                Console.WriteLine($"Not enough money! {priceForVacation:f2} lv needed.");
            }
        }
    }
}
