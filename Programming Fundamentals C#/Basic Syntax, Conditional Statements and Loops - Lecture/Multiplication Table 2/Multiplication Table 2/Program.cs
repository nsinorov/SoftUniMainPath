using System;

namespace Multiplication_Table_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if(n2 <= 10)
            {
                for (int i = n2; i <= 10; i++)
                {
                    Console.WriteLine($"{n1} X {i} = {n1 * i}");
                }
            }
            else
            {
                Console.WriteLine($"{n1} X {n2} = {n1 * n2}");
            }
        }
    }
}
