using System;

namespace Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int strongNum = int.Parse(Console.ReadLine());

            int strongNumCopy = strongNum;
            int sum = 0;

            while (strongNum > 0)
            {
                int factorialNum = 1;
                int currNum = strongNum % 10;
                strongNum /= 10;

                for (int i = 2; i <= currNum; i++)
                {
                    factorialNum *= i;

                }
                sum += factorialNum;
            }
            Console.WriteLine(sum == strongNumCopy ? "yes" : "no");
        }
    }
}
