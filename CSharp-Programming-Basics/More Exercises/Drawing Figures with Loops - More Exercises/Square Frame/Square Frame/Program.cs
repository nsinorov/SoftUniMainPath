using System;

namespace Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write("+ ");
                    for (int col = 1; col <= n - 2; col++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("| ");
                    for (int col = 1; col <= n - 2; col++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("|");
                }
            }

        }
    }
}
