using System;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputLenght = input.Length - 1;
            string inputReversed = "";

            for (int i = inputLenght; i >= 0; i--)
            {
                inputReversed += input[i];
            }
            Console.WriteLine(inputReversed);

        }
    }
}
