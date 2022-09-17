using System;

namespace Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
              int n = int.Parse(Console.ReadLine());
    
           while (n % 2 != 0)
           {          
                Console.WriteLine("Please write an even number.");

                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    return;
                }
           }
            

           if (n > 0 && n % 2 == 0)
           {
                Console.WriteLine($"The number is: {Math.Abs(n)}");
                return;
           }


            if (n < 0)
            {
                n = Math.Abs(n);

                if(n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {n}");
                }
               
                while(n % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");

                    n = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
