using System;

namespace Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double totalPrice = 0.00;

            switch (dayOfWeek)
            {
                case "Monday":                  
                case "Tuesday":                 
                case "Wednesday":                  
                case "Thursday":                
                case "Friday":
   
                    switch (fruit)
                    {
                        case "banana":
                            totalPrice = quantity * 2.50;
                            break;
                        case "apple":
                            totalPrice = quantity * 1.20;
                            break;
                        case "orange":
                            totalPrice = quantity * 0.85;
                            break;
                        case "grapefruit":
                            totalPrice = quantity * 1.45;
                            break;
                        case "kiwi":
                            totalPrice = quantity * 2.70;
                            break;
                        case "pineapple":
                            totalPrice = quantity * 5.50;
                            break;
                        case "grapes":
                            totalPrice = quantity * 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "Saturday":                
                case "Sunday":
              
                    switch (fruit)
                    {
                        case "banana":
                            totalPrice = quantity * 2.70;
                            break;
                        case "apple":
                            totalPrice = quantity * 1.25;
                            break;
                        case "orange":
                            totalPrice = quantity * 0.90;
                            break;
                        case "grapefruit":
                            totalPrice = quantity * 1.60;
                            break;
                        case "kiwi":
                            totalPrice = quantity * 3.00;
                            break;
                        case "pineapple":
                            totalPrice = quantity * 5.60;
                            break;
                        case "grapes":
                            totalPrice = quantity * 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (totalPrice > 0)
            {
                Console.WriteLine($"{totalPrice:F2}");
            }                  
        }
    }
}
