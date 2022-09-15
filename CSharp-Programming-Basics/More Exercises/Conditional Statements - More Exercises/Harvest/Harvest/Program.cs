using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double xGrapes = double.Parse(Console.ReadLine());
            double yGrapesForOneMeter = double.Parse(Console.ReadLine());   
            int neededWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = xGrapes * yGrapesForOneMeter;
            double wine = 0.4 * totalGrapes / 2.5;
            
            if(wine >= neededWine)
            {
                double totalWineForWorkers = wine - neededWine;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - neededWine)} liters left -> {Math.Ceiling(totalWineForWorkers / workers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine - wine)} liters wine needed.");
               
            }
        }
    }
}
