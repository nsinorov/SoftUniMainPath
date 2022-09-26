using System;

namespace Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int num = int.Parse(Console.ReadLine());

            int currNum = 0;
            int sum = 0;

            while (num > 0)
            {
                currNum = num % 10;
                num /= 10;
                sum += currNum;

            }

            Console.WriteLine(sum);         
        }
    }
}
