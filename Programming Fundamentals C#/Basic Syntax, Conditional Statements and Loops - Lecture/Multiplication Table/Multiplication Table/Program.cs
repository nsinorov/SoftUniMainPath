using System;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int n = int.Parse(Console.ReadLine());        

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }        
        }
    }
}
