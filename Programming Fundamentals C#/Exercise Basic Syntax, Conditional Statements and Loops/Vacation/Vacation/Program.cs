using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = numOfPeople * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = numOfPeople * 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = numOfPeople * 10.46;
                }

                if (numOfPeople >= 30)
                {
                    price -= (price * 0.15);
                }
            }

            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = numOfPeople * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = numOfPeople * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = numOfPeople * 16;
                }

                if (numOfPeople >= 100)
                {
                    price -= price / numOfPeople * 10;
                }
            }

            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = numOfPeople * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = numOfPeople * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = numOfPeople * 22.50;
                }

                if (numOfPeople >= 10 && numOfPeople <= 20)
                {
                    price -= (price * 0.05);
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
