using System;

namespace Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");

            }
        }
    }
}
