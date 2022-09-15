using System;

namespace Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n1 = int.Parse(Console.ReadLine()); 
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n1; i+= 2)
            {
                for (int j = 2; j <= n2; j++)
                {                 
                    for (int k = 2; k <= n3; k += 2)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }                       
                    }                                                                                                     
                }
            }
        }
    }
}
