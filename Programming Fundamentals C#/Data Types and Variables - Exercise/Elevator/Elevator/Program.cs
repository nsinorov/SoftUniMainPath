using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = (double)numOfPeople / capacity;

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
