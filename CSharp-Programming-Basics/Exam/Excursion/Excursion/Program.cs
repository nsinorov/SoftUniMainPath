using System;

namespace Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int oneNight = 20;
            double cardForTransport = 1.60;
            int ticketForMuseum = 6;

            // vhod
            int numOfPeople = int.Parse(Console.ReadLine());
            int numOfNights = int.Parse(Console.ReadLine());
            int numOfCards = int.Parse(Console.ReadLine());
            int numOfTicketsForMuseum = int.Parse(Console.ReadLine());

            // Към крайната сума се начислява допълнително 25% за непредвидени разходи. 

            int nights = numOfNights * oneNight;
            double priceForTransport = numOfCards * cardForTransport;
            int priceForTieckets = numOfTicketsForMuseum * ticketForMuseum;

            double totalPriceForOne = nights + priceForTransport + priceForTieckets;

            double totalPriceForAll = totalPriceForOne * numOfPeople;

            double sumOfUnforeseen = totalPriceForAll + (totalPriceForAll * 0.25);

            Console.WriteLine($"{sumOfUnforeseen:F2}");

        }
    }
}
