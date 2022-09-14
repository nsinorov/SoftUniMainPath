using System;

namespace Football_Kit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Знае се, че цената на шортите е 75% от цената на тениските
            //  а цената на чорапите е 20% от цената на шортите
            // Бутонките струват два пъти колкото тениската и шортите взети заедно
            // той има карта за отстъпка на стойност 15% от общата сума 

            //  Ако сметката на Пепи е по-висока или равна на дадена сума, той получава подарък - точно копие на топката от световното

            // Напишете програма, която изчислява дали Пепи е спечелил топката. 

            //vhod
            double priceOfOneShirt = double.Parse(Console.ReadLine()); // price of shirt 25
            double budgedNeeded = double.Parse(Console.ReadLine());
            
            double priceOfShorts = priceOfOneShirt * 0.75; // --> цена на шортите
            double priceOfSocks = priceOfShorts * 0.20; // --> цена на чорапите
            double priceOfButonki = (priceOfOneShirt + priceOfShorts) * 2;

            double totalSum = priceOfOneShirt + priceOfShorts + priceOfSocks + priceOfButonki;

            double sumAfterDiscount = totalSum - (totalSum * 0.15);

            if(sumAfterDiscount >= budgedNeeded)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sumAfterDiscount:F2} lv.");            
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {Math.Abs(sumAfterDiscount - budgedNeeded):F2} lv. more.");
            }
        }
    }
}
