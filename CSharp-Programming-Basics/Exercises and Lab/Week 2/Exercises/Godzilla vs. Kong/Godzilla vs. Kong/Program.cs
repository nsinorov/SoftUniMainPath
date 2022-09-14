using System;

namespace Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            double budged = double.Parse(Console.ReadLine());
            int numOfStatists = int.Parse(Console.ReadLine());
            double priceForOutfit = double.Parse(Console.ReadLine());

            double decor = budged * 0.1;

            if (numOfStatists >= 150)
            {
                priceForOutfit = priceForOutfit - (priceForOutfit *  0.1);
            }

            double sumForOutfit = numOfStatists * priceForOutfit;

            double totalPrice = decor + sumForOutfit;
            double totalLeft = budged - totalPrice;

            if (totalPrice > budged)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(totalLeft):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {totalLeft:F2} leva left.");
            }	    
        }
    }
}
