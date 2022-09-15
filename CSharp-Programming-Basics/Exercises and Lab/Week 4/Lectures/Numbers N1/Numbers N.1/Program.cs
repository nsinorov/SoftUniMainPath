using System;

namespace Numbers_from_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

           for(int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
