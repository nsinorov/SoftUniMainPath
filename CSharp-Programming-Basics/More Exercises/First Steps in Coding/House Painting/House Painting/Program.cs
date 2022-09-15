using System;

namespace House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double heightOfHouse = double.Parse(Console.ReadLine());
            double lenghtOfHouse = double.Parse(Console.ReadLine());
            double heightOfRoof = double.Parse(Console.ReadLine());

            double sideBlock = heightOfHouse * lenghtOfHouse;
            double window = 1.5 * 1.5;
            double sides = 2 * sideBlock - 2 * window;
            double entrance = 1.2 * 2;
            double backBlock = heightOfHouse * heightOfHouse;

            double faceAndBack = 2 * backBlock - entrance;
            double summary = sides + faceAndBack;

            double greenColor = summary / 3.4;
           
            // roof

            double twoRectangles = 2 * (heightOfHouse * lenghtOfHouse);
            double twoTriangles = 2 * (heightOfHouse * heightOfRoof / 2);
            double summary1 = twoRectangles + twoTriangles;

            double redColor = summary1 / 4.3;

            Console.WriteLine($"{greenColor:F2}");
            Console.WriteLine($"{redColor:F2}");
        }
    }
}
