using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double COFFEE = 1.50;
            const double WATER = 1.00;
            const double COKE = 1.40;
            const double SNACKS = 2.00;

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;

            price = totalPrice(COFFEE, WATER, COKE, SNACKS, product, quantity, price);

            Console.WriteLine($"{price:F2}");
        }

         static double totalPrice(double COFFEE, double WATER, double COKE, double SNACKS, string product, int quantity, double price)
        {
            switch (product)
            {
                case "coffee":
                    price = quantity * COFFEE;
                    break;
                case "water":
                    price = quantity * WATER;
                    break;
                case "coke":
                    price = quantity * COKE;
                    break;
                case "snacks":
                    price = quantity * SNACKS;
                    break;
                default:
                    break;
            }
            return price;
        }
    }
}
