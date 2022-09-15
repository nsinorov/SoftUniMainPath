using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int cakeSize = w * h;
            int cakePieces = 0;
            string input = Console.ReadLine();


            while(input != "STOP")
            {
                cakePieces+= int.Parse(input);

                if(cakePieces > cakeSize)
                {
                    break;
                }
                input = Console.ReadLine();

            }
            int diff = cakeSize - cakePieces;

            if(diff >= 0)
            {
                Console.WriteLine($"{diff} pieces are left.");
            }

            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(diff)} pieces more.");
            }
        }
    }
}
