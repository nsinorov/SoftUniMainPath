using System;

namespace Rhombus_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int n = int.Parse(Console.ReadLine());

            // upper part

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            // lower part

            for (int row = n - 1; row > 0; row--)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}

