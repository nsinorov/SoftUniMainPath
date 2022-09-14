using System;

namespace Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            string nameOfTheArchitect = Console.ReadLine();
            int numOfProjecst = int.Parse(Console.ReadLine());
            int oneProject = 3;
            int timeForAllProjects = numOfProjecst * oneProject; 

            Console.WriteLine($"The architect {nameOfTheArchitect} will need {timeForAllProjects} hours to complete {numOfProjecst} project/s.");
        }
    }
}
