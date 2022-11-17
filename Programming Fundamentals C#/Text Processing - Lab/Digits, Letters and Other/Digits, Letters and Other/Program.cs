using System;
using System.Linq;
using System.Text;

namespace Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var nums = new StringBuilder();
            var letters = new StringBuilder();
            var chars = new StringBuilder();


            for (int i = 0; i < input.Length; i++)
            {
                var chartext = input[i];

                if (char.IsDigit(chartext))
                {
                    nums.Append(chartext);
                }
                else if (char.IsLetter(chartext))
                {
                    letters.Append(chartext);
                }
                else
                {
                    chars.Append(chartext);
                }
            }
            Console.WriteLine($"{nums}\n{letters}\n{chars}");     
        }
    }
}
