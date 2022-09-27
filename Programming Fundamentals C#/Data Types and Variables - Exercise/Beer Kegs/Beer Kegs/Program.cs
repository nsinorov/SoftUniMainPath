using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int nLines = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;
            string biggestKegName = "";

            for (int i = 0; i < nLines; i++)
            {

                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfTheKeg = Math.PI * Math.Pow(radius, 2) * height;

                if(volumeOfTheKeg > biggestKeg)
                {
                    biggestKeg = volumeOfTheKeg;
                    biggestKegName = model;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
