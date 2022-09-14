using System;

namespace Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentScore = double.Parse(Console.ReadLine());

            if (currentScore >= 5.50) 
                {
                Console.WriteLine("Excellent!");
                }
        }
    }
}
