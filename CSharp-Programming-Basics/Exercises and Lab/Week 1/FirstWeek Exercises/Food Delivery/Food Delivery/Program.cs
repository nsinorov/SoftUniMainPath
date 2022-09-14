using System;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четем какво ни е дадено
            double menuChicken = 10.35;
            double menuFish = 12.40;
            double menuVegeterian = 8.15;
            double delivery = 2.50;
            //вход
            double quantitiChicken = double.Parse(Console.ReadLine());
            double quantitiFish = double.Parse(Console.ReadLine());
            double quantitiVegeterian = double.Parse(Console.ReadLine());

            double priceChicken = quantitiChicken * menuChicken;
            double priceFish = quantitiFish * menuFish;
            double priceVegeterian = quantitiVegeterian * menuVegeterian;
            //изчисления
            double sumPrice = priceChicken + priceFish + priceVegeterian;

            double dessert = sumPrice * 0.2;

            double totalPrice = sumPrice + dessert + delivery;
            //печат
            Console.Write(totalPrice);
        }
    }
}
