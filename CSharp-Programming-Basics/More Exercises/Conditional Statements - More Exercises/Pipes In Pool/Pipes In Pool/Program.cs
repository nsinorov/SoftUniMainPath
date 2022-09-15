using System;

namespace Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine()); 
            double H = double.Parse(Console.ReadLine());

            double pipe1Fill = P1 * H;
            double pipe2Fill = P2 * H;

            double sumPipes = pipe1Fill + pipe2Fill;
            
            if(sumPipes <= V)
            {
         
                Console.WriteLine($"The pool is {sumPipes / 10:F2}% full. Pipe 1: {pipe1Fill * 100 / sumPipes:F2}%. Pipe 2: {pipe2Fill * 100 / sumPipes:F2}%.");
            }
            else if(sumPipes > V)
            {
                Console.WriteLine($"For {H:F2} hours the pool overflows with {Math.Abs(sumPipes - V)} liters.");
            }
        }
    }
}
