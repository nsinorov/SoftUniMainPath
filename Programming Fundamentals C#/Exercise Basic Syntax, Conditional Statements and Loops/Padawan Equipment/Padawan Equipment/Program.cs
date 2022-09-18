using System;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());

            double priceForOneSaber = double.Parse(Console.ReadLine());
            double priceForOneRobe = double.Parse(Console.ReadLine());  
            double priceForOneBelts = double.Parse(Console.ReadLine());

            double totalPriceForSabers = Math.Ceiling(numOfStudents * 1.10);          
            double numbersOfFreeBelts = Math.Floor(numOfStudents / 6.0);

            double finalPriceForSabers = totalPriceForSabers * priceForOneSaber;
            double finalPriceForRobes = numOfStudents * priceForOneRobe;
            double finalPriceForBelts = (numOfStudents - numbersOfFreeBelts) * priceForOneBelts;


            double totalFinalPrice = finalPriceForSabers + finalPriceForRobes + finalPriceForBelts;

            if(budget >= totalFinalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalFinalPrice - budget):F2}lv more.");
            }
        }
    }
}
