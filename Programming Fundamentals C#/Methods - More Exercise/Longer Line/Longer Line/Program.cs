using System;

namespace Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            Longer(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        static void Closer(double x, double y, double z, double p) // Метод определящ коя точка е по-близо до (0,0)
        {
            if (x * x + y * y <= z * z + p * p)
            {
                Console.WriteLine($"({x}, {y})({z}, {p})");
            }

            else
            {
                Console.WriteLine($"({z}, {p})({x}, {y})");
            }
                
        }

        static void Longer(double a1, double b1, double a2, double b2, double a3, double b3, double a4, double b4)
        {
            double z1 = Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2); // дължината на квадрат на 1-та отсечка
            double z2 = Math.Pow(a3 - a4, 2) + Math.Pow(b3 - b4, 2); // дължината на квадрат на 2-та отсечка

            if (z1 >= z2)
            {
                Closer(a1, b1, a2, b2);
            }

            else
            {
                Closer(a3, b3, a4, b4);
            }              
        }
    }
}
