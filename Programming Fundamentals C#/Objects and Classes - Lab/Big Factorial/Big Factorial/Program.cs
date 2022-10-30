using System;
using System.Numerics;

namespace Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= num ; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
