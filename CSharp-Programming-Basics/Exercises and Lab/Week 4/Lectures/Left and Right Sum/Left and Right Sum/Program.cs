using System;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int count = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for(int counter = 0; counter < 2 * count; counter++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if(counter < count)
                {
                    leftSum += currentNum;
                }
                else
                {
                    rightSum += currentNum;
                }
            }
            if(leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
