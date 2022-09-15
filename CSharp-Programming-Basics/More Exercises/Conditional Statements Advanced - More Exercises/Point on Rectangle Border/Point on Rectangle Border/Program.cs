using System;

namespace Point_on_Rectangle_Border
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isAsideFromLeft = x >= x1;
            bool isAsideFromRight = x <= x2;

            bool isAsideFromTop = y >= y1;
            bool isAsideFromBottom = y <= y2;

            if ((x == x1 || x == x2) && isAsideFromTop && isAsideFromBottom || (y == y1 || y == y2) && isAsideFromLeft && isAsideFromRight)
            {
                Console.WriteLine("Border");
            }

            else Console.WriteLine("Inside / Outside");
        }
    }
}
