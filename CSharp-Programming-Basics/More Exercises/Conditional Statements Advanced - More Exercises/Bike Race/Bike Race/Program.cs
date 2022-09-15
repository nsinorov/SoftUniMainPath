using System;

namespace Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int juniorRacers = int.Parse(Console.ReadLine());
            int seniorRacers = int.Parse(Console.ReadLine());
            string kindOfTrack = Console.ReadLine();

            double totalSum = 0;
            double tax = 0;
            double endSum = 0;


            if (kindOfTrack == "trail")
            {
                totalSum = juniorRacers * 5.50 + seniorRacers * 7;
                tax = 0.05 * totalSum;
                endSum = totalSum - tax;
            }

            if (kindOfTrack == "cross-country" && juniorRacers + seniorRacers >= 50)
            {
                totalSum = juniorRacers * 8 + seniorRacers * 9.50;
                totalSum = totalSum - (totalSum * 0.25);
                tax = 0.05 * totalSum;
                endSum = totalSum - tax;
            }

           else if (kindOfTrack == "cross-country")
           {
                totalSum = juniorRacers * 8 + seniorRacers * 9.50;
                tax = 0.05 * totalSum;
                endSum = totalSum - tax;
           }
            
           if (kindOfTrack == "downhill")
            {
                totalSum = juniorRacers * 12.25 + seniorRacers * 13.75;
                tax = 0.05 * totalSum;
                endSum = totalSum - tax;
            }

           if (kindOfTrack == "road")
            {
                totalSum = juniorRacers * 20 + seniorRacers * 21.50;
                tax = 0.05 * totalSum;
                endSum = totalSum - tax;
            }

            Console.WriteLine($"{endSum:f2}");
        }
    }
}
