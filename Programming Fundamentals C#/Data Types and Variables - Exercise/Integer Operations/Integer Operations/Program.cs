using System;

namespace Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int sum = 0;
            sum = num1 + num2;

            int divide = 0;
            divide = sum / num3;

            int multiply = 0;
            multiply = divide * num4;

            Console.WriteLine(multiply);
        }
    }
}
