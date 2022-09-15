using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();      
            double totalSummer = 0.00;    
            double totalWinter = 0.00;

            if(budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        totalSummer = budget * 0.3;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {totalSummer:F2}");
                        break;
                    case "winter":
                        totalWinter = budget * 0.7;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {totalWinter:F2}");
                        break;
                    default:
                        break;
                }
            }
            else if(budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        totalSummer = budget * 0.4;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Camp - {totalSummer:F2}");
                        break;
                    case "winter":
                        totalWinter = budget * 0.8;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {totalWinter:F2}");
                        break;
                    default:
                        break;
                }
            }
            else if(budget > 1000)
            {
                budget = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget:F2}");
            }    
        }
    }
}
