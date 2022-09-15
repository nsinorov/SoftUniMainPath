using System;

namespace Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while(sum < number)
            {
                int currentNumber = int.Parse((Console.ReadLine()));
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
