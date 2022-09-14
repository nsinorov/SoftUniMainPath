using System;

namespace USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double bgn = usd * 1.94;

            Console.Write(bgn);
        }
    }
}
