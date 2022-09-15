using System;

namespace Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double skumriq = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double kiloOfPalamud = double.Parse(Console.ReadLine());
            double kiloOfSafrid = double.Parse(Console.ReadLine());
            double kiloOfMidi = double.Parse(Console.ReadLine());

            double priceOfPalamud = skumriq + skumriq * 0.6;
            double sumOfPalamud = priceOfPalamud * kiloOfPalamud;

            double priceOfSafrid = caca + caca * 0.80;
            double sumOfSafrid = priceOfSafrid * kiloOfSafrid;

            double sumOfMidi = kiloOfMidi * 7.5;

            double price = sumOfPalamud + sumOfSafrid + sumOfMidi;
            Console.WriteLine($"{price:F2}");
        }
    }
}
