using System;

namespace Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int num = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= num; rows++)
            {
                PrintColumns(rows);
            }

            for (int rows = num - 1; rows >= 1; rows--)
            {
                PrintColumns(rows);
            }
        }
        private static void PrintColumns(int rows)
        {
            for (int cols = 1; cols <= rows; cols++)
            {
                Console.Write($"{cols} ");
            }
            Console.WriteLine();
        }
    }
}
