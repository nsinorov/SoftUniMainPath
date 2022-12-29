using System;

namespace Tri_bit_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 7 << position;// we need 111 at current position and int 7 = 111

            int result = number ^ mask;//1 ^ 1 = 0, 0 ^ 1 = 1

            Console.WriteLine(result);
        }
    }
}
