using System;

namespace Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packagePens = 5.80;
            double packageMarkers = 7.20;
            double cleaningDetergent = 1.20; //за литър

           int numPackagePens = int.Parse(Console.ReadLine());
           int numPackageMarkers = int.Parse(Console.ReadLine());  
           int littersCleaner = int.Parse(Console.ReadLine());
           double discount = double.Parse(Console.ReadLine());

            double priceForPens = numPackagePens * packagePens;
            double priceForMarkers = numPackageMarkers * packageMarkers;
            double priceForCleaningDetergent = littersCleaner * cleaningDetergent;

            double price = priceForPens + priceForMarkers + priceForCleaningDetergent ;

            double totalPrice = price - (price * discount) * 0.01;

            Console.Write(totalPrice);
        }
    }
}
