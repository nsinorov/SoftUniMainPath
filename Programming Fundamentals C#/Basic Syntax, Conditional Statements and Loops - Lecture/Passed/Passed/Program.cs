using System;

namespace Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            double grade = double.Parse(Console.ReadLine());

            if(grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
