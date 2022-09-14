using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceForOneYear = int.Parse(Console.ReadLine());

            double priceSneakers = priceForOneYear - priceForOneYear * 0.4;
            double priceOutfit = priceSneakers - priceSneakers * 0.2;
            double ball = priceOutfit / 4;
            double accessories = ball / 5;

            double totalExpenses = priceForOneYear + priceSneakers + priceOutfit + ball + accessories;

            Console.Write(totalExpenses);

        }
    }
}
