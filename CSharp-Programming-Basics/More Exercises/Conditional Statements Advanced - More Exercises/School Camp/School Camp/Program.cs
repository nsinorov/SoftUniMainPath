using System;

namespace School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int numOfStudents = int.Parse(Console.ReadLine());
            int numOfNights = int.Parse(Console.ReadLine());

          
            double totalSum = 0;

            if (season == "Winter")
            {
                if (typeOfGroup == "boys" || typeOfGroup == "girls")
                {
                    totalSum = numOfStudents * 9.60 * numOfNights;
                }
                else if (typeOfGroup == "mixed")
                {
                    totalSum = numOfStudents * 10 * numOfNights;
                }

            }
            else if(season == "Spring")
            {
                if (typeOfGroup == "boys" || typeOfGroup == "girls")
                {
                    totalSum = numOfStudents * 7.20 * numOfNights;
                }
                else if (typeOfGroup == "mixed")
                {
                    totalSum = numOfStudents * 9.50 * numOfNights;
                }
            }
            else if(season == "Summer")
            {
                if (typeOfGroup == "boys" || typeOfGroup == "girls")
                {
                    totalSum = numOfStudents * 15 * numOfNights;
                }
                else if (typeOfGroup == "mixed")
                {
                    totalSum = numOfStudents * 20 * numOfNights;
                }
            }
           
            if(numOfStudents >= 50)
            {
                totalSum = totalSum - (totalSum * 0.5);
            }
            else if(numOfStudents >= 20 && numOfStudents < 50)
            {
                totalSum = totalSum - (totalSum * 0.15);
            }
            else if(numOfStudents >= 10 && numOfStudents < 20)
            {
                totalSum = totalSum - (totalSum * 0.05);
            }

            string typeOfSport = string.Empty;

            if (season == "Winter")
            {             
                if (typeOfGroup == "girls")
                {
                    typeOfSport = "Gymnastics";
                }
                else if (typeOfGroup == "boys")
                {
                    typeOfSport = "Judo";
                }
                else if(typeOfGroup == "mixed")
                {
                    typeOfSport = "Ski";
                }
            }
           
             else if (season == "Spring")
             {
                if (typeOfGroup == "girls")
                {
                    typeOfSport = "Athletics";
                }
                else if (typeOfGroup == "boys")
                {
                    typeOfSport = "Tennis";
                }
                else if (typeOfGroup == "mixed")
                {
                    typeOfSport = "Cycling";
                }

             }

            else if (season == "Summer")
            {
                if (typeOfGroup == "girls")
                {
                    typeOfSport = "Volleyball";
                }
                else if (typeOfGroup == "boys")
                {
                    typeOfSport = "Football";
                }
                else if (typeOfGroup == "mixed")
                {
                    typeOfSport = "Swimming";
                }

            }

            Console.WriteLine($"{typeOfSport} {totalSum:F2} lv.");

        }
    }
}
