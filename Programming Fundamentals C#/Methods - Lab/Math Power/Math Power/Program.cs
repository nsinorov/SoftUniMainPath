using System;

namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numBase = double.Parse(Console.ReadLine());
            int numPower = int.Parse(Console.ReadLine());
        
            double result = PowerUp(numBase, numPower);
            Console.WriteLine(result);
        }
         static double PowerUp(double numBase, int numPower)
        {
            return Math.Pow(numBase, numPower);
        }
    }
}
