using System;

namespace Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numOfCargo = int.Parse(Console.ReadLine());

            double totalTons = 0;
            double averagePriceForTon = 0;
            double microbus = 0;
            double truck = 0;
            double train = 0;

            for (int i = 1; i <= numOfCargo; i++)
            {
                double tons = double.Parse(Console.ReadLine());

                totalTons += tons;
 
                if (tons <= 3)
                {
                    microbus += tons;
                }

                if(tons >= 4 && tons <= 11)
                {
                    truck += tons;
                }
                if(tons >= 12)
                {
                    train += tons;
                }         
                averagePriceForTon += tons;
            }

            double cargo = microbus + truck + train;
            averagePriceForTon = (microbus * 200 + truck * 175 + train * 120) / cargo;

            Console.WriteLine($"{averagePriceForTon:F2}");
            Console.WriteLine("{0:f2}%", microbus / cargo * 100);
            Console.WriteLine("{0:f2}%", truck / cargo * 100);
            Console.WriteLine("{0:f2}%", train / cargo * 100);
        }
    }
}
