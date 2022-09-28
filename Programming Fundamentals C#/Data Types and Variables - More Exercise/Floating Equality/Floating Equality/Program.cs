using System;

namespace Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPS = 0.000001;

            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double difference = Math.Abs(number1 - number2);

            if (difference < EPS)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}