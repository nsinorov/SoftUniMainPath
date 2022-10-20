using System;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfClient = Console.ReadLine();

            double tax = 0;
            double priceWithoutTax = 0;
            double totalPrice = 0;
            double priceWithTax = 0;
            double finalPrice = 0;

            while (typeOfClient != "regular" && typeOfClient != "special")
            {
                double prizeForParts = double.Parse(typeOfClient);

                if (prizeForParts < 0)
                {
                    Console.WriteLine("Invalid price!");
                    typeOfClient = Console.ReadLine();
                }

                else
                {
                    totalPrice += prizeForParts;
                    tax = totalPrice * 0.2;
                    priceWithTax = totalPrice + tax;

                    typeOfClient = Console.ReadLine();
                }
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }

            else if (typeOfClient == "special")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:F2}$");
                Console.WriteLine($"Taxes: {tax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {priceWithTax - (priceWithTax * 0.1):F2}$");

            }
            else if (typeOfClient == "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:F2}$");
                Console.WriteLine($"Taxes: {tax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {priceWithTax:F2}$");

            }
        }
    }
}
