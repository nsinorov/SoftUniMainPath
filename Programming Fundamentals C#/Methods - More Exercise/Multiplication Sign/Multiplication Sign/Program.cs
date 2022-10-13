using System;

namespace Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            ResultSign(num1, num2, num3);
        }
        public static void ResultSign(double n1, double n2, double n3)
        {
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");
            }
            else if ((n1 > 0 && n2 > 0 && n3 > 0) || (n1 < 0 && n2 < 0 && n3 > 0) || (n1 < 0 && n2 > 0 && n3 < 0) || (n1 > 0 && n2 < 0 && n3 < 0))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
