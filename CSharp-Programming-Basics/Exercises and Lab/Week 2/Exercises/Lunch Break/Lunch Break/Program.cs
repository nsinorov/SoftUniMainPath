using System;

namespace Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfSeries = Console.ReadLine();
            int lenghtOfEpisode = int.Parse(Console.ReadLine());
            int lenghtOfBreak = int.Parse(Console.ReadLine());

            double timeForLunch = lenghtOfBreak * 5 / 8.0;

            if (timeForLunch >= lenghtOfEpisode)
            {
                Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {Math.Ceiling(timeForLunch - lenghtOfEpisode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {Math.Ceiling(lenghtOfEpisode - timeForLunch)} more minutes.");
            }
        }
    }
}
