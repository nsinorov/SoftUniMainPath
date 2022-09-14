using System;

namespace World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            double neededDistance = distanceInMeters * timeInSec;

            double every15Meters = (Math.Floor(distanceInMeters / 15)) * 12.5;

            double sumTime = Math.Abs(neededDistance + every15Meters);

            if (recordInSeconds > sumTime)
            {
                double toralNewRecord = neededDistance + every15Meters;
                Console.WriteLine($"Yes, he succeeded! The new world record is {toralNewRecord:F2} seconds.");             
            }
            else if (recordInSeconds <= sumTime)
            {
                double totalTimeSlower = sumTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {totalTimeSlower:F2} seconds slower.");
            }
        }
    }
}
