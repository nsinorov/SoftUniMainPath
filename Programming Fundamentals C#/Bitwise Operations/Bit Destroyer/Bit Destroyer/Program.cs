using System;

namespace Bit_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());


            int mask = ~(1 << position);//after shift left with position we have mask with 1 value at current position and another are 0, but with ~(not) we have mask with 0 value at current position and another are 1

            int result = (number & mask);// taken the whole number with set 0 only at current position and now we have another number

            Console.WriteLine(result);
        }
    }
}
