using System;

namespace Train
{
    internal class Program
    {
        static void Main()
        {
            int numOfWagons = int.Parse(Console.ReadLine());

            int[] countOfPassengers = new int[numOfWagons];
            int sum = 0;

            for (int i = 0; i < numOfWagons; i++)
            {
                int currPassengers = int.Parse(Console.ReadLine());
                countOfPassengers[i] += currPassengers;
                sum += currPassengers;
                
            }
            Console.WriteLine(String.Join(" ", countOfPassengers));
            Console.WriteLine(sum);
        }
    }
}
