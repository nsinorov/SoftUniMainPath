using System;

namespace Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //vhod 

            int nQuantityOfDays = int.Parse(Console.ReadLine());
            double mKmForOneDay = double.Parse(Console.ReadLine());

            double progress = mKmForOneDay;

            //for and logic

            for (int i = 0; i < nQuantityOfDays; i++)
            {
                double nextDay = double.Parse(Console.ReadLine());
                mKmForOneDay = mKmForOneDay + mKmForOneDay * (nextDay / 100);
                progress += mKmForOneDay;
            }
            if(progress >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(progress - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - progress)} more kilometers");
            }
        }
    }
}
