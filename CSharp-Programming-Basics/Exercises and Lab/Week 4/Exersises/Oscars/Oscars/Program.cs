using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string assesorName = "";
            double assesorPoints = 0;

            for(int i = 1; i <= n; i++)
            {
          
                assesorName = Console.ReadLine();
                assesorPoints = double.Parse(Console.ReadLine());

                points += assesorName.Length * assesorPoints / 2;

                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {(points):F1}!");
                    break;
                }
            }

            if(points < 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {(1250.5 - points):F1} more!");
            }
        }
    }
}
