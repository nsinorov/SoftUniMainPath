using System;

namespace Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int countOfNums = int.Parse(Console.ReadLine());
            int sumOfNums = 0;

            for(int counter = 0; counter < countOfNums; counter++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sumOfNums += currentNum;
            }
            Console.WriteLine(sumOfNums);
        }
    }
}
