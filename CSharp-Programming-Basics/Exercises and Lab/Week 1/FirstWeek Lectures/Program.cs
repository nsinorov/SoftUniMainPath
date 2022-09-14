using System;

namespace Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double num = double.Parse(Console.ReadLine());
            double inches = 2.54;
            double centemeters = num * inches;
            Console.WriteLine(centemeters);
        }
    }
}
