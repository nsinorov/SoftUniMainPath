using System;

namespace Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            //We need to separete the commands, first we separete the Command from the value with || and then we read the value
            string[] travelRoute = Console.ReadLine().Split(new string[] {"||", " "}, StringSplitOptions.RemoveEmptyEntries);


            int startingFuel = int.Parse(Console.ReadLine());
            int startingAmmo = int.Parse(Console.ReadLine());

            // Reading commands and doing the logic
            for (int i = 0; i < travelRoute.Length; i += 2)
            {
                // reading the commands
                string command = travelRoute[i];
            
                if (command == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    break;
                }
                // reading the value's, either i+1 or just 1
                int value = int.Parse(travelRoute[i + 1]);

                if (command == "Travel")
                {
                    if (startingFuel >= value)
                    {
                        Console.WriteLine($"The spaceship travelled {value} light-years.");
                        startingFuel -= value;
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }
                else if (command == "Enemy")
                {
                    if (startingAmmo >= value)
                    {
                        Console.WriteLine($"An enemy with {value} armour is defeated.");
                        startingAmmo -= value;
                    }
                    else if (startingFuel >= value * 2)
                    {
                        Console.WriteLine($"An enemy with {value} armour is outmaneuvered.");
                        startingFuel -= value * 2;
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }
                else if(command == "Repair")
                {
                    Console.WriteLine($"Ammunitions added: {value * 2}.");
                    Console.WriteLine($"Fuel added: {value}.");
                    startingFuel += value;
                    startingAmmo += value * 2;
                }
            }
        }
    }
}
