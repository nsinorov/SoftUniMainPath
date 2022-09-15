using System;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftedFood = int.Parse(Console.ReadLine());
            double foodDog = double.Parse(Console.ReadLine());
            double foodCat = double.Parse(Console.ReadLine());
            double foodTurtle = double.Parse(Console.ReadLine());

            double neededFoodDog = days * foodDog;
            double neededFoodCat = days * foodCat;
            double neededFoodTurtle = (days * foodTurtle) / 1000.0;

            double totalSum = neededFoodDog + neededFoodCat + neededFoodTurtle;

            if(leftedFood >= totalSum)
            {
                Console.WriteLine($"{Math.Floor(leftedFood - totalSum)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalSum - leftedFood)} more kilos of food are needed.");
            }
        }
    }
}
