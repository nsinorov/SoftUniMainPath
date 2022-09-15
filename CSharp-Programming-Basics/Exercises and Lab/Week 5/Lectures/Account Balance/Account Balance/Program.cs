using System;

namespace Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            double totalAmount = 0;

            while(input != "NoMoreMoney")
            {
                double currentAmount = double.Parse(input);

                if(currentAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                        break;
                }
                Console.WriteLine($"Increase: {currentAmount:F2}");
                totalAmount += currentAmount;
                input = Console.ReadLine();
            }
          
            Console.WriteLine($"Total: {totalAmount:F2}");             
        }
    }
}
