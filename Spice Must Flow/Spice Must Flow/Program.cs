using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MIN_SPICES_TO_GATHER = 100;
            const int DAILY_DECREES_OF_MINE_YIELD = 10;

            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCount = 0;

            while(countOfSpices >= MIN_SPICES_TO_GATHER)
            {
                totalConsumed += countOfSpices - CONSUMED_BY_WORKERS;
                countOfSpices -= DAILY_DECREES_OF_MINE_YIELD;
                daysCount++;

                if(countOfSpices < MIN_SPICES_TO_GATHER)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }
            }
            Console.WriteLine(daysCount);
            Console.WriteLine(totalConsumed);
        }
    }
}
