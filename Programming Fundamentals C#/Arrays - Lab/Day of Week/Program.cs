using System;

namespace Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string[] daysOfWeeks = new string[7] {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
          
            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(daysOfWeeks[day - 1]);
        }
    }
}
