using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {    
            int rows = int.Parse(Console.ReadLine());

            // Create a 2D array to store the triangle
            int[][] triangle = new int[rows][];

            // Set the first row to 1
            triangle[0] = new int[] { 1 };

            // Generate the rest of the rows
            for (int i = 1; i < rows; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1;

                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }

            // Print the triangle
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
