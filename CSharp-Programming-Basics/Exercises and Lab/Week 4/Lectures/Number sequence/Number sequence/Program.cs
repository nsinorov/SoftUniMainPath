using System;

namespace Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            int num = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int counter = 0; counter < num; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if(currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }

                if(currentNumber < minNum)
                {
                    minNum = currentNumber;
                }           
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
