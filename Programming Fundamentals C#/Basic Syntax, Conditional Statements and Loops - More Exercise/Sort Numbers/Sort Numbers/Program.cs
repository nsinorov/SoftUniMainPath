using System;

namespace Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1);

                if(n2 > n3)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                }
            }
            else if(n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2);

                if(n1 > n3)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                }
            }
            else if(n3 > n1 && n3 > n2)
            {
                Console.WriteLine(n3);

                if(n1 > n2)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
            }
        }
    }
}
