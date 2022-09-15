using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string name = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine());
            double totalRating = 0;
            double avarageRating = 0;
            int currentClassNumber = 1;
            int fails = 0;

            while(currentClassNumber <= 12)
            {
                if(rating < 4.00)
                {
                    fails++;
                }
                if(fails == 2)
                {
                    currentClassNumber--;
                    Console.WriteLine($"{name} has been excluded at {currentClassNumber} grade");
                    break;
                }
                totalRating += rating;
                avarageRating = totalRating / currentClassNumber;
                currentClassNumber++;
                if(currentClassNumber > 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {avarageRating:F2}");
                    break;
                }
                rating = double.Parse(Console.ReadLine());
            }       
        }
    }
}
