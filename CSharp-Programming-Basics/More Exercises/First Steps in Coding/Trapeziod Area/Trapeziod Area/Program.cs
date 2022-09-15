using System;

namespace Trapeziod_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double face = (b1 + b2) * h/2;

            Console.WriteLine($"{face:F2}");
        }
    }
}
