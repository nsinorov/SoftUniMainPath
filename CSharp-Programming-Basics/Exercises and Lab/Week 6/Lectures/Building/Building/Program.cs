using System;

namespace Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for(int currFloor = floors; currFloor >= 1; currFloor--)
            {
                for(int currRoom = 0; currRoom < rooms; currRoom++)
                {
                    if (currFloor == floors)
                    {
                        Console.Write($"L{currFloor}{currRoom} ");
                    }

                    else if(currFloor % 2 == 0)
                    {
                        Console.Write($"O{currFloor}{currRoom} ");
                    }

                    else
                    {
                        Console.Write($"A{currFloor}{currRoom} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
