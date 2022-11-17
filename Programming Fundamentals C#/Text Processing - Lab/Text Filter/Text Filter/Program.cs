using System;

namespace Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] keyWord = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var currBanWord in keyWord)
            {
                text = text.Replace(currBanWord, new string('*', currBanWord.Length));
                
            }
            Console.WriteLine(text);
        }
    }
}
