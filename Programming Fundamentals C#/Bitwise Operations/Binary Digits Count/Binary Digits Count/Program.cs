using System;

namespace Binary_Digits_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int zeroOrOne = int.Parse(Console.ReadLine()); // 0 or 1

            int counter = 0; // how many zero's or one's

            while (num > 0)
            {

                int leftOver = num % 2;

                if (leftOver == zeroOrOne)
                {
                    counter++;
                }

                num /= 2;
            }

            Console.WriteLine(counter);
        }
    }
}
