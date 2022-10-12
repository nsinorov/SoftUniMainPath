using System;

namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double result1 = Factorial(num1);
            double resilt2 = Factorial(num2);

            Console.WriteLine($"{result1 / resilt2:F2}");

        }
        private static double Factorial(int num1)
        {
           double result = 1;

            while(num1 != 1)
            {
                result *= num1;
                num1--;
            }
            return result;
        }
    }
}
