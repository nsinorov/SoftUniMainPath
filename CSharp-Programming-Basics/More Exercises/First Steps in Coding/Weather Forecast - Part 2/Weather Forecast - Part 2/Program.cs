using System;

namespace Weather_Forecast___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double degrees = double.Parse(Console.ReadLine());

            if(degrees >= 5 && degrees <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if(degrees >= 12 && degrees <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if(degrees >= 15 && degrees <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if(degrees >= 20.1 && degrees <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if(degrees >= 26 && degrees <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
