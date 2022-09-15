using System;

namespace Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ticket category
            double vip = 499.99;
            double normal = 249.99;

            // entrance
            double budged = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numOfPeople = int.Parse(Console.ReadLine());

            double transport = 0;
            double priceForTickets = 0;

            if (numOfPeople >= 1 && numOfPeople <= 4)
            {
                transport = budged - (budged * 0.75);
            }
            else if(numOfPeople >= 5 && numOfPeople <= 9)
            {
                transport = budged - (budged * 0.60);
            }
            else if(numOfPeople >= 10 && numOfPeople <= 24)
            {
                transport = budged - (budged * 0.50);
            }
            else if(numOfPeople >= 25 && numOfPeople <= 49)
            {
                transport = budged - (budged * 0.40);
            }
            else if(numOfPeople > 50)
            {
                transport = budged - (budged * 0.25);
            }
          
            if(category == "Normal")
            {
                priceForTickets = normal * numOfPeople;
               
            }
            else if(category == "VIP")
            {
                priceForTickets = vip * numOfPeople;
            }

            double totalPrice = Math.Abs(priceForTickets -transport);

            if (transport >= priceForTickets)
            {
                Console.WriteLine($"Yes! You have {totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(priceForTickets - transport):F2} leva.");
            }     
        }
    }
}
