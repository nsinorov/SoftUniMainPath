using System;

namespace Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdInput} {secondInput} {firstInput}");
        }
    }
}
