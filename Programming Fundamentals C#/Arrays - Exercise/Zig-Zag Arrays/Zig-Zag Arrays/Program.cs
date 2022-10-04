using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            int n = int.Parse(Console.ReadLine());

            int[] evenArr = new int[n];
            int[] oddArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenArr[i] = currNums[0];
                    oddArr[i] = currNums[1];
                }
                else
                {
                    evenArr[i] = currNums[1];
                    oddArr[i] = currNums[0];
                }
            }
            Console.WriteLine(String.Join(" ", evenArr));
            Console.WriteLine(String.Join(" ", oddArr));
        }
    }
}
