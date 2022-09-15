using System;

namespace Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());

            double average = 0;

            for (int counter = 0; counter < num; counter++)
            {
                double currNum = double.Parse(Console.ReadLine());

                average += currNum;          
            }
            average = average / num;
            Console.WriteLine($"{average:F2}");
        }
    }
}
