using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countOfOrders = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double price = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {         

                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
           
                 price = ((days * capsuleCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${price:F2}");           
                totalPrice += price;

                if (countOfOrders > 1)
                {                
                    continue;                
                }               

            }       
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
