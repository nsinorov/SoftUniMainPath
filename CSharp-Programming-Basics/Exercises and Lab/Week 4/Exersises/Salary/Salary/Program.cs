using System;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            string site = "";

            for(int i = 0; i < n; i++)
            {
                site = Console.ReadLine();

                if(site == "Facebook")
                {
                    salary -= 150;
                }
                else if(site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site == "Reddit")
                {
                    salary -= 50;
                }

                if(salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }        
            }
            if(salary > 0)
            {
                Console.WriteLine(Math.Round(salary));
            }
        }
    }
}
