using System;

namespace Square_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                for (int d = 0; d < n - 1; d++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
