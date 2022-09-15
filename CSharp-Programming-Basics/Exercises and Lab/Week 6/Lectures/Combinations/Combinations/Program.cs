using System;

namespace Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;

            for(int firstNum = 0; firstNum <= magicNum; firstNum++)
            {
                for(int secondNum = 0; secondNum <= magicNum; secondNum++)
                {
                    for(int thirdNum = 0; thirdNum <= magicNum; thirdNum++)
                    {
                        if(firstNum + secondNum + thirdNum == magicNum)
                        {
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
