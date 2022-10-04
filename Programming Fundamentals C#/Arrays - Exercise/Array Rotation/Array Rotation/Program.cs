using System;
using System.Linq;

namespace Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int rotarion = 0; rotarion < rotations; rotarion++)
            {
                int tempElement = input[0];

                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }

                input[input.Length - 1] = tempElement;
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
