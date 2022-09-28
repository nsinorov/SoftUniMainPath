using System;
using System.Linq;

namespace From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesNumber; i++)
            {
                string input = Console.ReadLine();

                string leftNumber = "";
                string rightNumber = "";
                int count = 0;

                for (int j = 0; j < input.Length - 1; j++)
                {
                    char symbol = input[j];
                    if (symbol != ' ')
                    {
                        leftNumber += symbol;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int k = count + 1; k < input.Length; k++)
                {
                    char symbol = input[k];
                    rightNumber += symbol;
                }

                long left = long.Parse(leftNumber);
                long right = long.Parse(rightNumber);

                long maxNumber = Math.Max(left, right);
                long sum = 0;

                while (Math.Abs(maxNumber) > 0)
                {
                    sum += maxNumber % 10;
                    maxNumber /= 10;
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
