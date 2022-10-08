using System;

namespace Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = RectangleArea(a, b);

            Console.WriteLine(result);
        }

         static int RectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
