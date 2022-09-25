using System;

namespace Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            char input = char.Parse(Console.ReadLine());

            if (Char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
