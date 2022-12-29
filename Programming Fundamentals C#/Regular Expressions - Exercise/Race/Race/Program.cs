using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<names>[A-Za-z])|(?<distance>[0-9])");
            //Regex regexDistance = new Regex(@"[0-9]");
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var racers = new Dictionary<string, int>();

            foreach (string currName in names)
            {
                racers.Add(currName, 0);
            }

            //MatchCollection namesAndDistance = new MatchCollection();
            string input;
            StringBuilder name = new StringBuilder();
            while ((input = Console.ReadLine()) != "end of race")
            {
                int distance = 0;
                MatchCollection namesAndDistance = regex.Matches(input);
                foreach (Match match in namesAndDistance)
                {
                    string inte = match.Groups["distance"].Value;
                    //int currDistance = int.Parse(match.Groups["distance"].Value);

                    if (int.TryParse(match.Groups["distance"].Value, out int currDistance))
                    {
                        distance += currDistance;
                    }
                    else
                    {
                        string currName = match.Groups["names"].Value;
                        //string currName = match;
                        name.Append(currName);
                    }
                }
                if (racers.ContainsKey(name.ToString()))
                {
                    racers[name.ToString()] += distance;
                }
                name.Clear();
            }

            racers = racers
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);
            int i = 1;
            foreach (var (currName, distance) in racers)
            {
                if (i == 1)
                {
                    Console.WriteLine($"1st place: {currName}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"2nd place: {currName}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"3rd place: {currName}");
                    break;
                }
                i++;
            }
        }
    }
}