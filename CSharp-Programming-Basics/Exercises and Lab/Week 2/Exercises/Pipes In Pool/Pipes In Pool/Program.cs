using System;

namespace Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int areaV = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

                double filledPool =  areaV *(pipe1 + pipe2) / hours;
            if (filledPool < 1.0)
            {
                Console.WriteLine($"The pool is {filledPool}. Pipe 1: { }. Pipe 2: {}.")
            }





        }
    }
}
