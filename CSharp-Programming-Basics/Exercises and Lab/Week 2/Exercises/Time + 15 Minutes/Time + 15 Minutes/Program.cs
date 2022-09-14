using System;

namespace Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int  min = int.Parse(Console.ReadLine());

            min += (hours * 60);

            int minAfter15Min = min + 15;

            int hAfter = minAfter15Min / 60;
            int minAfter = minAfter15Min % 60;

            if (hAfter > 23)
            {
                hAfter = 0;
            }

            if ( minAfter < 10)
            {
                Console.WriteLine($"{hAfter}:0{minAfter}");
            }
            else
            {
                Console.WriteLine($"{hAfter}:{minAfter}");
            }
           
        }
    }
}

