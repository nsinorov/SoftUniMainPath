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

            int finalResult = (num1 + num2) / num3 * num4;

            Console.WriteLine(finalResult);
        }
    }
}
