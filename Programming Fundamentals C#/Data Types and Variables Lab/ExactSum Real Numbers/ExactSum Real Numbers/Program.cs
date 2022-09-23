using System;

namespace ExactSum_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {

              decimal currNum = decimal.Parse(Console.ReadLine());

                sum += currNum;
               
            }
            Console.WriteLine(sum);
        }
    }
}
