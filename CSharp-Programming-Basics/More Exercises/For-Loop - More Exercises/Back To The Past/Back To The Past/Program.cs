using System;

namespace Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            double yearsold = 17;

            for (int year = 1800; year <= yearToLive; year++)
            {
                if (year % 2 == 0)
                {
                    money = money - 12000;

                }
                else if (year % 2 != 0)
                {
                    yearsold += 2;
                    money = money - (12000 + (50 * yearsold));

                }

            }
            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(money));
            }
        }
    }
}
