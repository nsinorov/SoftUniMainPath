using System;

namespace Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int prevSum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += int.Parse(Console.ReadLine());
                sum += int.Parse(Console.ReadLine());

                if (i > 1)
                {

                    diff = Math.Abs(sum - prevSum);
                }

                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }

                prevSum = sum;
                sum = 0;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={prevSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }

        }
    }
}
