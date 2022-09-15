using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;
            double totalSum = 0.00;

            if(projection == "Premiere")
            {
                totalSum = (row * column) * premiere;
            }
            else if(projection == "Normal")
            {
                totalSum = (row * column) * normal;             
            }
            else if(projection == "Discount")
            {
                totalSum = (row * column) * discount;           
            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
