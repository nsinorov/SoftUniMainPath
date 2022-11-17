using System;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            string specialWord = Console.ReadLine();

            string text = Console.ReadLine();

            while (text.Contains(specialWord))
                
            {
                int startIndex = text.IndexOf(specialWord);

                text = text.Remove(startIndex, specialWord.Length);
            }
            Console.WriteLine(text);
        }
    }
}
