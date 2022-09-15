using System;

namespace Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int restingDays = int.Parse(Console.ReadLine());

            int workingDays = 365 - restingDays;
            int timeForPlay = workingDays;
            int realTimeToPlay = timeForPlay * 63 + restingDays * 127;
            int diffFromNorm = Math.Abs(30000 - realTimeToPlay);

            int H = diffFromNorm / 60;
            int M = diffFromNorm % 60;

            if(realTimeToPlay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{H} hours and {M} minutes more for play");
            }
            else if(realTimeToPlay < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{H} hours and {M} minutes less for play");


            }
        }
    }
}
