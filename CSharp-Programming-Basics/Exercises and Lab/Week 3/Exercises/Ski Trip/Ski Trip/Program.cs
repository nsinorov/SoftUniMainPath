using System;

namespace Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int daysStaying = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine(); 
            string score = Console.ReadLine();
            daysStaying = daysStaying - 1;
            double midSum = 0;
            double totalSum = 0;
    
          if(typeOfRoom == "room for one person" && daysStaying < 10)
            {
                midSum = daysStaying * 18.00;            
            }

          else if(typeOfRoom == "room for one person" && daysStaying < 15)
            {
                midSum = daysStaying * 18.00;            
            }

          else if(typeOfRoom == "room for one person" && daysStaying > 15)
            {
                midSum = daysStaying * 18.00;         
            }

            if (typeOfRoom == "apartment" && daysStaying < 10)
            {
                midSum = (daysStaying * 25.00);
                midSum = midSum - (midSum * 0.3);
            }

          else if(typeOfRoom == "apartment" && daysStaying < 15)
            {
                midSum = (daysStaying * 25.00);
                midSum = midSum - (midSum * 0.35);           
            }

          else if(typeOfRoom == "apartment" && daysStaying > 15)
            {
                midSum = (daysStaying * 25.00);
                midSum = midSum - (midSum * 0.5);
            }

          if(typeOfRoom == "president apartment" && daysStaying < 10)
            {
                midSum = (daysStaying * 35.00);
                midSum = midSum - (midSum * 0.1);
            }

          else if(typeOfRoom == "president apartment" && daysStaying < 15)
            {
                midSum = (daysStaying * 35.00);
                midSum = midSum - (midSum * 0.15);
            }

            else if (typeOfRoom == "president apartment" && daysStaying > 15)
            {
                midSum = (daysStaying * 35.00);
                midSum = midSum - (midSum * 0.2);
            }

          if(score == "positive")
            {
                totalSum = midSum + (midSum * 0.25);
                Console.WriteLine($"{totalSum:F2}");
            }

            else if(score == "negative")
            {
                totalSum = midSum - (midSum * 0.1);
                Console.WriteLine($"{totalSum:F2}");
            }
        }
    }
}
