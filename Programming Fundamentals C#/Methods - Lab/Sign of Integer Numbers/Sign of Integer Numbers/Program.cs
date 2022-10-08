using System;

namespace Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            checkNum(num);
        }
        static void checkNum(int num)
        {
            if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}
