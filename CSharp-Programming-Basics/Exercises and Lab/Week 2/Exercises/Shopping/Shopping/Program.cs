using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            int numVideoCards = int.Parse(Console.ReadLine());
            int numCPU = int.Parse(Console.ReadLine());
            int numRams = int.Parse(Console.ReadLine());
     
            int priceForVideoCards = numVideoCards * 250;

            double priceOfCPU = 0.35 * priceForVideoCards;
            double sumOfCPUs = numCPU * priceOfCPU;

            double priceForRam = 0.1 * priceForVideoCards;
            double sumOfRam = numRams * priceForRam;

            double totalPrice = priceForVideoCards + sumOfCPUs + sumOfRam;

            bool discount = numVideoCards > numCPU;

            if (discount)
            {
                totalPrice *= 0.85;
            }
            bool enoughMoney = totalPrice <= budged;

            if (enoughMoney)
            {
                double moneyLeft = budged - totalPrice;
                Console.WriteLine($"You have {moneyLeft:F2} leva left!");
            }
            else 
            {       
                double moneyNeeded = totalPrice - budged;
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyNeeded):F2} leva more!");
            }             
        }
    }
}
