using System;

namespace The_Hunting_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());

            // for on person for 1 day, but I simply multiply it from the start as it could be done
            double water = double.Parse(Console.ReadLine()) * playersCount * days;
            double food = double.Parse(Console.ReadLine()) * playersCount * days;

            bool isEnergyEnough = true;
            for (int i = 1; i <= days; i++)
            {
                double currLostEnergy = double.Parse(Console.ReadLine());
                // first we need to check if the the group has energy and everyday the energy get's reduced.
                if(groupsEnergy - currLostEnergy <= 0)
                {
                    isEnergyEnough = false;
                    break;
                }
                else
                {
                    groupsEnergy -= currLostEnergy;
                }
                //every 2nd day check
                if(i % 2 == 0)
                {
                    groupsEnergy *= 1.05;
                    water *= 0.7;
                }
                // every 3rd day check
                if(i % 3 == 0)
                {
                    food -= food / playersCount;
                    groupsEnergy *= 1.1;
                }        
            }
            // Output
            if (isEnergyEnough)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:F2} energy!");
            }
            else 
            {
                Console.WriteLine($"You will run out of energy. You will be left with {food:F2} food and {water:F2} water.");
            }
        }
    }
}
