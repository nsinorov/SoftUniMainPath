using System;
using System.Linq;

namespace Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            while (input != "end")
            {
                char[] chars = input.ToCharArray();
                Array.Reverse(chars);
                string reversedString = new string(chars);
                Console.WriteLine($"{input} = {reversedString}");
                input = Console.ReadLine();
            }
           
        }
    }
}
