using System;

namespace Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int expectedAmount = int.Parse(Console.ReadLine());

            int countTransactions = 0;
            double collectedAmount = 0;
            double totalAmountCash = 0;
            double totalAmountCard = 0;

            int cashCounter = 0;
            int creditCardCounter = 0;

            string command = "";

            while ((command = Console.ReadLine()) != "End" || collectedAmount == expectedAmount)
            {
                countTransactions++;
                int amountOfProduct = int.Parse(command);

                if (countTransactions % 2 == 0)
                {
                    if (amountOfProduct < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else if (amountOfProduct > 10)
                    {
                        Console.WriteLine("Product sold!");
                        totalAmountCard += amountOfProduct;
                        creditCardCounter++;             
                    }
                }

                else
                {
                    if (amountOfProduct > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        totalAmountCash += amountOfProduct;
                        cashCounter++;
                    }
                }

                collectedAmount = totalAmountCash + totalAmountCard;

                if (collectedAmount >= expectedAmount)
                {
                    Console.WriteLine($"Average CS: {totalAmountCash / cashCounter:F2}");
                    Console.WriteLine($"Average CC: {totalAmountCard / creditCardCounter:F2}");
                    break;
                }
            }         

            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
