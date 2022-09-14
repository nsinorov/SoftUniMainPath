using System;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine()); 
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            //изчисления
             int volumeAquarium = lenght * width * height; //см^3 
             double volumeLitters = volumeAquarium * 0.001;

            percentage = percentage * 0.01;

            double neededLitters = volumeLitters * (1 - percentage);

            Console.Write(neededLitters);
        }
    }
}
