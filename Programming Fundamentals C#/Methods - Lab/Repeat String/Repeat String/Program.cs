using System;

namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Output(input, count);

        }
         static void Output(string input, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(input);
            }
        }
    }
}
