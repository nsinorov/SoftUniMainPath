using System;

namespace NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            MatrixOfNums(n);



        }

         static void MatrixOfNums(int n)
        {

            for (int rows = 0; rows < n ; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
