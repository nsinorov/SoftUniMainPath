using System;
using System.Linq;
using System.Collections.Generic;

namespace Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> handOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> handTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (handOne.Count > 0 && handTwo.Count > 0)
            {

                if (handOne[0] > handTwo[0])
                {
                    handOne.Add(handOne[0]);
                    handOne.Add(handTwo[0]);
                }
                else if (handOne[0] < handTwo[0])
                {
                    handTwo.Add(handTwo[0]);
                    handTwo.Add(handOne[0]);
                }

                handOne.Remove(handOne[0]);
                handTwo.Remove(handTwo[0]);

                if (handOne.Count == 0)
                {
                    int sum = handTwo.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                if (handTwo.Count == 0)
                {
                    int sum = handOne.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
