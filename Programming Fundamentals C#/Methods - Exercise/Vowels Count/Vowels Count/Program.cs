using System;
using System.Linq;

namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            string input = Console.ReadLine().ToLower();
            SearchForVowels(input);
        }

         static void SearchForVowels(string input)
        {
            Console.WriteLine(input.Count(vowels => "aouei".Contains(vowels)));
        }
    }
}
