using System;

namespace Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double magnolii = 3.25;
            int ziombiuli = 4;
            double roses = 3.50;
            int cactus = 8;

            int numMagnolii = int.Parse(Console.ReadLine());
            int numZiombiuli = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numCactuses = int.Parse(Console.ReadLine());
            double pricePresent = double.Parse(Console.ReadLine());

            double sum = magnolii * numMagnolii + ziombiuli * numZiombiuli + roses * numRoses + cactus * numCactuses;

            double tax = sum - (sum * 0.05);

            if (pricePresent > tax)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(pricePresent - tax)} leva.");
            }
            else if(pricePresent <= tax)
            {          
                Console.WriteLine($"She is left with {Math.Floor(tax - pricePresent)} leva.");
            }

        }
    } 
}
