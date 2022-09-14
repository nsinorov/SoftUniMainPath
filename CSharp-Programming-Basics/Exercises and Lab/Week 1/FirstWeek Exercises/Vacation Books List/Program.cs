using System;

namespace Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int numPages = int.Parse(Console.ReadLine());
            int pagesForOneHour = int.Parse(Console.ReadLine());    
            int days = int.Parse(Console.ReadLine());

            int sumTime = numPages / pagesForOneHour;
            int neededHours = sumTime / days;

            Console.Write(neededHours);
        }
    }
}
