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

With For Loop

using System;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
                counter++;
                sum += i;

                if(counter == n)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

