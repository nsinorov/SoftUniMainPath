using System;

namespace Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // vhod
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int l = 2; l <= num1; num1 += 2)
            {
                for (int k = 2; k <= num2; num2++)
                {
                    for (int j = 2; j <= num3; num3 += 2)
                    {
                       if(num2 == 2 || num2 == 3 || num2 == 5 || num2 == 7)
                        {
                            Console.Write($"{l} {k} {j} ");
                        }
                                   
                    }
                }
            }

        }
    }
}
