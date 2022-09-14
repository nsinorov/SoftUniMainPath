using System;

namespace Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //vhod
            int targetForTheDay = int.Parse(Console.ReadLine());
           double earnedMoney = 0;

            string working = "";
      
            while (working != "closed" || earnedMoney >= targetForTheDay)
            {
                if (earnedMoney >= targetForTheDay)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {earnedMoney}lv.");
                    break;
                }
                string typeOfService = Console.ReadLine();

                if (typeOfService == "haircut")
                {
                    string type = Console.ReadLine();

                    if (type == "ladies")
                    {
                        earnedMoney += 20;                                  
                    }
                   
                    else if (type == "mens")
                    {
                        earnedMoney += 15;
                       
                    }             
                    else if (type == "kids")
                    {
                        earnedMoney += 10;              
                    }                
                    continue;
                }

                else if (typeOfService == "color")
                {
                    string service = Console.ReadLine();

                    if (service == "touch up")
                    {
                        earnedMoney += 20;
                    }
                    else if (service == "full color")
                    {
                        earnedMoney += 30;
                    }                 
                    continue;                 
                }
             
                if (earnedMoney < targetForTheDay)
                {
                    Console.WriteLine($"Target not reached! You need {targetForTheDay - earnedMoney}lv. more.");
                    Console.WriteLine($"Earned money: {earnedMoney}lv.");
                    break;
                }
               
            }        
        }
    }
}
