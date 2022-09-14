using System;

namespace Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // vhod
            double weightOfPackageInKg = double.Parse(Console.ReadLine());  
            string typeOfService = Console.ReadLine();
            int distanceInKm = int.Parse(Console.ReadLine());

            double endSum = 0;
    
            // danni

          if (typeOfService == "standard")
            {
                if(weightOfPackageInKg < 1)
                {
                       endSum = distanceInKm * 0.03;
                }
                else if(weightOfPackageInKg >= 1 && weightOfPackageInKg <= 10)
                {
                    endSum = distanceInKm * 0.05;
                }
                else if(weightOfPackageInKg >= 10 && weightOfPackageInKg < 40)
                {
                    endSum = distanceInKm * 0.10;
                }
                else if (weightOfPackageInKg >= 40 && weightOfPackageInKg < 90)
                {
                    endSum = distanceInKm * 0.15;
                }
                else if (weightOfPackageInKg >= 90 && weightOfPackageInKg <= 150)
                {
                    endSum = distanceInKm * 0.20;
                }
                Console.WriteLine($"The delivery of your shipment with weight of {weightOfPackageInKg:F3} kg. would cost {endSum:F2} lv.");
            }

            double nadcenkaForKg = 0;
            double nadcenkaForKm = 0;
            double totalNadcenka = 0;
            double totalSum = 0;

            if (typeOfService == "express")
            {
                if(weightOfPackageInKg < 1)
                {
                    endSum = distanceInKm * 0.03;
                    nadcenkaForKg = 0.8 * 0.03;
                    nadcenkaForKm = weightOfPackageInKg * nadcenkaForKg;
                    totalNadcenka = distanceInKm * nadcenkaForKm;
                    totalSum = endSum + totalNadcenka;
                }
              else  if (weightOfPackageInKg >= 1 && weightOfPackageInKg < 10)
                {
                    endSum = distanceInKm * 0.05;
                    nadcenkaForKg = 0.4 * 0.05;
                    nadcenkaForKm = weightOfPackageInKg * nadcenkaForKg;
                    totalNadcenka = distanceInKm * nadcenkaForKm;
                    totalSum = endSum + totalNadcenka;
                }
              else  if (weightOfPackageInKg >= 10 && weightOfPackageInKg < 40)
                {
                    endSum = distanceInKm * 0.10;
                    nadcenkaForKg = 0.05 * 0.10;
                    nadcenkaForKm = weightOfPackageInKg * nadcenkaForKg;
                    totalNadcenka = distanceInKm * nadcenkaForKm;
                    totalSum = endSum + totalNadcenka;
                }
               else if (weightOfPackageInKg >= 40 && weightOfPackageInKg < 90)
                {
                    endSum = distanceInKm * 0.15;
                    nadcenkaForKg = 0.02 * 0.15;
                    nadcenkaForKm = weightOfPackageInKg * nadcenkaForKg;
                    totalNadcenka = distanceInKm * nadcenkaForKm;
                    totalSum = endSum + totalNadcenka;

                }
                else if (weightOfPackageInKg >= 90 && weightOfPackageInKg <= 150)
                {
                    endSum = distanceInKm * 0.20;
                    nadcenkaForKg = 0.01 * 0.20;
                    nadcenkaForKm = weightOfPackageInKg * nadcenkaForKg;
                    totalNadcenka = distanceInKm * nadcenkaForKm;
                    totalSum = endSum + totalNadcenka;
                }
                Console.WriteLine($"The delivery of your shipment with weight of {weightOfPackageInKg:F3} kg. would cost {totalSum:F2} lv.");
            }       
    }
}
}
