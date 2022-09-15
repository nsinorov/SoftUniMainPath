using System;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int hrizantemi = int.Parse(Console.ReadLine()); 
            int roses = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double totalSum = 0;

            int totalHrizantemi = 0;
            int totalRoses = 0;
            int totalLaleta = 0;
      

            if (season == "Spring" || season == "Summer")
            {
                double oneHrizantema = 2.00;
                double oneRose = 4.10;
                double oneLale = 2.50;

                totalSum = hrizantemi * oneHrizantema + roses * oneRose + laleta * oneLale;
            }
            
            else if (season == "Autumn" || season == "Winter")
            {
                double oneHrizantema = 3.75;
                double oneRose = 4.50;
                double oneLale = 4.15;

                totalSum = hrizantemi * oneHrizantema + roses * oneRose + laleta * oneLale;
            }
     

            if (holiday == "Y")
            {
                totalSum = totalSum + (totalSum * 0.15);
            }

            if(laleta > 7 && season == "Spring")
            {
                totalSum = totalSum - (totalSum * 0.05);
            }

            if(roses >= 10 && season == "Winter")
            {
                totalSum = totalSum - (totalSum * 0.1);
            }

            if(hrizantemi + laleta + roses > 20)
            {
                totalSum = totalSum - (totalSum * 0.2);
            }

          Console.WriteLine($"{totalSum + 2:F2}");


        }
    }
}
