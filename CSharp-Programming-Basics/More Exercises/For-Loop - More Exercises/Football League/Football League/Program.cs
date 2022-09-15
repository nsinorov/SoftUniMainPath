using System;

namespace Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double capacityOfStadion = double.Parse(Console.ReadLine());  
            double numOfFans = double.Parse(Console.ReadLine());

            double fansFromA = 0;
            double fansFromB = 0;

            double fansFromG = 0;
            double fansFromV = 0;

            double allFansFromA = 0;
            double allFansFromB = 0;
            double allFansFromG = 0;
            double allFansFromV = 0;
            double allFans = 0;
    
            for (int counter = 0; counter < numOfFans; counter++)
            {           

                string currSector = Console.ReadLine();

                if(currSector == "A")
                {
                    fansFromA++;
                }
                else if(currSector == "B")
                {
                    fansFromB++;
                }
               else if(currSector == "G")
                {
                    fansFromG++;
                }
               else if(currSector == "V")
                {
                    fansFromV++;
                }

                
            }

            allFansFromA = fansFromA / numOfFans * 100;
            allFansFromB = fansFromB / numOfFans * 100;
            allFansFromG = fansFromG / numOfFans * 100;
            allFansFromV = fansFromV / numOfFans * 100;

            allFans = numOfFans / capacityOfStadion * 100;        

            Console.WriteLine($"{allFansFromA:F2}%");
            Console.WriteLine($"{allFansFromB:F2}%");
            Console.WriteLine($"{allFansFromV:F2}%");
            Console.WriteLine($"{allFansFromG:F2}%");         
            Console.WriteLine($"{allFans:F2}%");

        }
    }
}
