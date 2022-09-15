using System;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;    

            for (int counter = 1; counter <= count; counter++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (counter % 2 == 0)
                {
                   evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }      

            if (evenSum == oddSum)
            {          
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
