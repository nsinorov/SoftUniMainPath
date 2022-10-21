using System;
using System.Linq;
using System.Collections.Generic;

namespace The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> stateOfLift = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


            int peopleOnTheCurrentWagon = 0;
            int peopleonTheLyft = 0;
            bool isNoMorePeople = false;

            List<int> wagonList = stateOfLift;

            // 15
            // 0 0 0 0

            for (int i = 0; i < stateOfLift.Count; i++)
            {

                while (stateOfLift[i] < 4)
                {
                    stateOfLift[i]++;
                    peopleOnTheCurrentWagon++;

                    if (peopleonTheLyft + peopleOnTheCurrentWagon == peopleWaiting)
                    {
                        isNoMorePeople = true;
                        break;
                    }
                }
                peopleonTheLyft += peopleOnTheCurrentWagon;

                if (isNoMorePeople)
                {
                    break;
                }
                peopleOnTheCurrentWagon = 0;
            }

            if (peopleWaiting < stateOfLift.Count * 4 && stateOfLift.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', wagonList));
            }
            else if (peopleWaiting > peopleonTheLyft)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting - peopleonTheLyft} people in a queue!");
                Console.WriteLine(string.Join(' ', wagonList));
            }
            else if (stateOfLift.All(w => w == 4) && isNoMorePeople == true)
            {
                Console.WriteLine(string.Join(' ', wagonList));
            }
        }
    }
}
