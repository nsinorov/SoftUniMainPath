using System;

namespace Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            string trip = Console.ReadLine();

            switch (trip)
            {
                case "day":
                    if(n < 20)
                    {
                        double taxi = 0.70 + n * 0.79;
                        Console.WriteLine($"{taxi:F2}");
                        break;
                    }
                    if (n >= 20 && n <= 99)
                    {
                        double bus = n * 0.09;
                        Console.WriteLine($"{bus:F2}");
                    }                             
                   else if(n >= 100)
                    {
                        double train = n * 0.06;
                        Console.WriteLine($"{train:F2}");
                    }
                    break;
                   
                case "night":
                    if(n < 20)
                    {
                        double taxi = 0.70 + n * 0.9;
                        Console.WriteLine($"{taxi:F2}");
                        break;
                    }
                    if(n >= 20 && n <= 99)
                    { 
                        double bus = n * 0.09;
                        Console.WriteLine($"{bus:F2}");
                        break;                     
                    }               
                    else if(n >= 100)
                    {
                        double train = n * 0.06;
                        Console.WriteLine($"{train:F2}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
