using System;

namespace Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double singleDogFood = 2.50;
            double singleCatFood = 4;
            int foodQuantityForDogs = int.Parse(Console.ReadLine());
            int foodQuantityForCats = int.Parse(Console.ReadLine());

            double totalPrice = (foodQuantityForDogs * singleDogFood)+ (foodQuantityForCats * singleCatFood);

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
