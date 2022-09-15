using System;

namespace Rectangle_of_N_x_N_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < num; counter++)
            {
                Console.WriteLine(new String('*', num));
            }
        }
    }
}
