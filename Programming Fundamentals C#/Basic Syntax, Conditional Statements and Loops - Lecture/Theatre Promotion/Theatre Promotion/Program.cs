using System;

namespace Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string dayOfWeek = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

          

            if (dayOfWeek == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 12;
                }
            }

                else if (dayOfWeek == "Weekend")
                {
                    if (age >= 0 && age <= 18)
                    {
                        ticketPrice = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketPrice = 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticketPrice = 15;
                    }

                }

                   else if (dayOfWeek == "Holiday")
                   {
                        if (age >= 0 && age <= 18)
                        {
                            ticketPrice = 5;
                        }
                        else if (age > 18 && age <= 64)
                        {
                            ticketPrice = 12;
                        }
                        else if (age > 64 && age <= 122)
                        {
                            ticketPrice = 10;
                        }
                   }
            
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");           
            }
            else
            {
                Console.WriteLine($"{ticketPrice}$");
            }            
        }
    }
}
