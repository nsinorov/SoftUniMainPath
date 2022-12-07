using System;
using System.Text.RegularExpressions;

namespace Boss_Rush
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numsOfInputs = int.Parse(Console.ReadLine());

            string pattern = @"\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";

            var Regex = new Regex(pattern);

            for (int i = 0; i < numsOfInputs; i++)
            {
                string input = Console.ReadLine();
                Match match= Regex.Match(input);

                if (match.Success)
                {
                    var boss = match.Groups["boss"].Value;
                    var title = match.Groups["title"].Value;

                    Console.WriteLine($"{boss}, The {title}");
                    Console.WriteLine($">> Strength: {boss.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
