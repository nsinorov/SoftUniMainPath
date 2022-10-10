using System;

namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int absValue = Math.Abs(int.Parse(input));

            int sumOfEvenNums = GetSumOfEvenNums(absValue.ToString());
            int sumOfOddNums = GetSumOfOddDigits(absValue.ToString());

            int result = sumOfEvenNums * sumOfOddNums;
            Console.WriteLine(result);

        }

         static int GetSumOfEvenNums(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currNum = int.Parse(input[i].ToString());
                if(currNum % 2 == 0)
                {
                    sum += currNum;
                }           
            }
            return sum;
        }
         static int GetSumOfOddDigits(string input)
        {

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currNum = Math.Abs(int.Parse(input[i].ToString()));
                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }
            }
            return sum;
         }
    }
}
