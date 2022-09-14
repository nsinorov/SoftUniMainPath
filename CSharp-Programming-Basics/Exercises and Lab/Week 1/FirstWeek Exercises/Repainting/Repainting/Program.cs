using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //променливите
            double nylon = 1.50; //за кв.м
            double paint = 14.50; // за литър
            double thinner = 5.00; // за литър
            double priceForBag = 0.40;
            //вход в конзолата
            double neededNylon = double.Parse(Console.ReadLine());
            double neededPaint = double.Parse(Console.ReadLine());   
            double neededThinner = double.Parse(Console.ReadLine());
            double hoursForTheJob = double.Parse(Console.ReadLine());
            //изчисления
            double priceNylon = (neededNylon + 2) * nylon;
            double pricePaint = ( neededPaint + neededPaint * 0.1)  * paint; //  double pricePaint = ( neededPaint * 1.1)  * paint
            double priceThinner = neededThinner * thinner;

            double sum = priceNylon + pricePaint + priceThinner + priceForBag;

            double sumWorkers = (sum * 0.3) * hoursForTheJob;

            double totalPrice = sum + sumWorkers;
            //печат на конзолата
            Console.Write(totalPrice);
        }
    }
}
