using System;

namespace Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int startingNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combination = 0;
            bool isFound = false;

            for(int firstNum = startingNum; firstNum <= endNum; firstNum++)
            {
                for(int secondNum = startingNum; secondNum <= endNum; secondNum++)
                {
                    combination++;
                    if(firstNum + secondNum == magicNum)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combination} ({firstNum} + {secondNum} = {magicNum})");
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNum}");               
            }
        }
    }
}
