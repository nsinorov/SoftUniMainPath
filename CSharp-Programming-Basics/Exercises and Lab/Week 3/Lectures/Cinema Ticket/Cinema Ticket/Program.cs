using System;

namespace Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string day = Console.ReadLine();
           int priceForTicket = 0;
            switch (day)
            {
                case "Monday":
                    priceForTicket = 12;
                    break;
                case "Tuesday":
                    priceForTicket = 12;
                    break;
                case "Friday":            //тарикатски/глупав номер ;)
                    priceForTicket = 12; 
                    break;
                case "Thursday":
                    priceForTicket = 14;
                    break;
                case "Wednesday":
                    priceForTicket = 14;
                    break;
                case "Saturday":
                    priceForTicket = 16;
                    break;
                case "Sunday":
                    priceForTicket = 16;
                    break;
                    default:                 
                    break;
            }
            Console.WriteLine(priceForTicket);
        }
    }
}
