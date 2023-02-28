using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Coffee coffee = new("Americano", 10);
            MainDish main = new("Potatoes", 6, 250);
            Cake cake = new("Banana cake");
            ColdBeverage coldDrink = new("Pepsi", 2, 330);

            Console.WriteLine($"{coffee.Name}, {coffee.Price}, {coffee.Caffeine}, {coffee.Milliliters}");
        }
    }
}