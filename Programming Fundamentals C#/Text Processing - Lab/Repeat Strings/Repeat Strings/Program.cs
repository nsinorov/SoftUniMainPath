using System;

namespace Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string result = string.Empty;

            foreach (var word in words)
            {           
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
