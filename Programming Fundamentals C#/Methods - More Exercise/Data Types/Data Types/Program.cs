using System;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string typeOfData = Console.ReadLine();

            if(typeOfData == "int")
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num * 2);
            }

            if(typeOfData == "real")
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num * 1.5:F2}");
            }

            if(typeOfData == "string")
            {
                string input = Console.ReadLine();
                Console.WriteLine($"${input}$");
            }
        }
    }
}
