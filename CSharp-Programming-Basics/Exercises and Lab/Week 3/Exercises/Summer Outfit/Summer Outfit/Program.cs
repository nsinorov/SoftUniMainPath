using System;

namespace Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int celsius = int. Parse(Console.ReadLine());
           string timeOfDay = Console.ReadLine();

            if (celsius >= 10 && celsius <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    string outfit = "Sweatshirt";
                    string shoes = "Sneakers";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
            }
                if(celsius > 18 && celsius <= 24)
                {
                    if(timeOfDay == "Afternoon")
                    {
                        string outfit = "T-Shirt";
                        string shoes = "Sandals";
                        Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                    }
                    else if(timeOfDay == "Morning" || timeOfDay == "Evening")
                    {
                        string outfit = "Shirt";
                        string shoes = "Moccasins";
                        Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                    }
                }

                if(celsius >= 25)
                {
                    if(timeOfDay == "Morning")
                    {
                        string outfit = "T-Shirt";
                        string shoes = "Sandals";
                        Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                    }
                    else if(timeOfDay == "Afternoon")
                    {
                        string outfit = "Swim Suit";
                        string shoes = "Barefoot";
                        Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                    }
                    else if(timeOfDay == "Evening")
                    {
                        string outfit = "Shirt";
                        string shoes = "Moccasins";
                        Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                    }
                }                         
        }
    }
}
