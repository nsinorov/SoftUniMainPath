using System;

namespace Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();
            int litters = int.Parse(Console.ReadLine());

            while (type != "Gasoline" && type != "Gas" && type != "Diesel")
            {
                Console.WriteLine("Invalid fuel!");
                break;
            }

            if (type == "Gasoline" && litters >= 25)
            {
                Console.WriteLine($"You have enough gasoline.");
            }
            else if(type == "Gas" && litters >= 25)
            {
                Console.WriteLine($"You have enough gas.");
            }
            else if(type == "Diesel" && litters >= 25)
            {
                Console.WriteLine($"You have enough diesel.");            
            }
            
            
            if(type == "Gasoline" && litters < 25)
            {
                Console.WriteLine($"Fill your tank with gasoline!");
            }
            else if(type == "Gas" && litters < 25)
            {
                Console.WriteLine($"Fill your tank with gas!");
            }
            else if(type == "Diesel" && litters < 25)
            {
                Console.WriteLine($"Fill your tank with diesel!");
            }

            
        }
    }
}
