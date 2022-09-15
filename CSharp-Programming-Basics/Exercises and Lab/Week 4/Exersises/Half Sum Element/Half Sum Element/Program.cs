using System;

namespace Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int sum = 0;
            int maxNum = int.MinValue;

            for(int counter = 1; counter <= n; counter++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                
                if(num > maxNum)
                {
                    maxNum = num;
                }
            }
            sum -= maxNum; 
            if(sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}
