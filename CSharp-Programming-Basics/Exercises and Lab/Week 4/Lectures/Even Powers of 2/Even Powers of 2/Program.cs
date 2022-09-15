using System;

namespace Numbers_1.N_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = 1;

            for(int counter = 0; counter <= number; counter +=2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
