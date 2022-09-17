using System;

namespace Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int startingNum = 1;

            while(n > 0)
            {
                Console.WriteLine(startingNum);

                sum += startingNum;

                startingNum += 2;

                n--;
            }        
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
