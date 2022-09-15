using System;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMach = double.Parse(Console.ReadLine());
            double priceOfOneToy = double.Parse(Console.ReadLine());

            double savedMoney = 0;

            for(int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    savedMoney += i * 5 - 1;
                }
                else
                {
                    savedMoney += priceOfOneToy;
                }
            }
            if(savedMoney >= priceOfWashingMach)
            {
                Console.WriteLine($"Yes! {savedMoney - priceOfWashingMach:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceOfWashingMach - savedMoney:F2}");
            }
        }
    }
}
