using System;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encrypted = string.Empty;

            foreach (char currChar in input)
            {
                int intPosition = currChar;
                intPosition += 3;
                encrypted += (char)intPosition;
            }
            Console.WriteLine(encrypted);
        }
    }
}
