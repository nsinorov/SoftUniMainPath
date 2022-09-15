using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double roses = 5.00;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3.00;
            double gladiolus = 2.50;

            double totalSum = 0.00;
            double tempSum;

            switch (flower)
            {
                case "Roses":

                    tempSum = roses * numOfFlowers;
                    totalSum = tempSum;

                    if(numOfFlowers > 80)
                    {
                        totalSum = tempSum - (tempSum * 0.1);
                       
                    }
                    break;

                case "Dahlias":

                    tempSum = dahlias * numOfFlowers;
                    totalSum = tempSum; 
                    
                    if(numOfFlowers > 90)
                    {
                        totalSum = tempSum - (tempSum * 0.15);
                    }
                    break;

                case "Tulips":
                    tempSum = tulips * numOfFlowers;
                    totalSum = tempSum;

                    if(numOfFlowers > 80)
                    {
                        totalSum = tempSum - (tempSum * 0.15);
                    }
                    break;

                case "Narcissus":
                    tempSum = narcissus * numOfFlowers;
                    totalSum = tempSum;

                    if(numOfFlowers < 120)
                    {
                        totalSum = tempSum + (tempSum * 0.15);
                    }
                    break;

                case "Gladiolus":
                    tempSum = gladiolus * numOfFlowers;
                    totalSum = tempSum;

                    if(numOfFlowers < 80)
                    {
                        totalSum = tempSum + (tempSum * 0.2);
                    }
                    break;

                default:
                     break;
            }
            if(budget >= totalSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flower} and {budget - totalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalSum - budget:F2} leva more.");
            }             
        }
    }
}
