using System;

namespace Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0.00;

            switch (town)
            {
                case "Sofia":
                    if(0 <= sales && sales <= 500)
                    {
                        commision = 0.05;
                    }
                    else if(500 < sales && sales <= 1000)
                    {
                        commision = 0.07;
                    }
                    else if (1000 < sales && sales <=10000)
                    {
                        commision = 0.08;
                    }
                    else if(sales > 10000)
                    {
                        commision = 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        commision = 0.045;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commision = 0.075;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commision = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        commision = 0.055;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commision = 0.08;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commision = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            double totalSum = sales * commision;

            if(commision > 0)
            {
                Console.WriteLine($"{totalSum:F2}");
            }
        }
    }
}
