using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main()
        {
            const int CAPACITY = 255;
            int totalCapacity = CAPACITY;
        
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                int quantityOfWater = int.Parse((Console.ReadLine()));

                if(totalCapacity - quantityOfWater >= 0)
                {
                    totalCapacity -= quantityOfWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            int totalFilledQuantity = CAPACITY - totalCapacity;
            Console.WriteLine(totalFilledQuantity);
        }
    }
}
