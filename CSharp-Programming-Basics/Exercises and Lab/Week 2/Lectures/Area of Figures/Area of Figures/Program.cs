using System;

namespace Area_of_Figures
{
   internal class Program
    {
        static void Main(string[] args)
        {     
            string figureName = Console.ReadLine();
           
            if (figureName == "square")
            {             
                double side1 = double.Parse(Console.ReadLine());
                double finalResult = side1 * side1; 
                Console.WriteLine($"{finalResult:F3}");
            }
            else if (figureName == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double finalResult = sideA * sideB;
                Console.WriteLine($"{finalResult:F3}");
            }
            else if (figureName == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double finalResult = radius * radius * Math.PI;
                Console.WriteLine($"{finalResult:F3}");
            }
            else if (figureName == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double finalResult = side * height / 2;
                Console.WriteLine($"{finalResult:F3}");
            }

        }
    }
}

// тарикатско

using System;

namespace Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureName = Console.ReadLine();
            double finalResult = 0;

            if (figureName == "square")
            {
                double side1 = double.Parse(Console.ReadLine());
                finalResult = side1 * side1;
            }
            else if (figureName == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                finalResult = sideA * sideB;
            }
            else if (figureName == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                finalResult = radius * radius * Math.PI;
            }
            else if (figureName == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                finalResult = side * height / 2;             
            }
            if (finalResult > 0)
            {
                Console.WriteLine($"{finalResult:F3}");
            }

        }
    }
}
