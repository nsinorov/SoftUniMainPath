using System;

namespace Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int startingNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startingNum; i <= endNum; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine();
            Console.Write($"Sum: {sum}");
        }
    }
}
