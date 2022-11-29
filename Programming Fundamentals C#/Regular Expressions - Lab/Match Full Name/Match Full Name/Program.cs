using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
