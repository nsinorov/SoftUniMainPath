using System;

namespace Triangle_of_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int num = int.Parse(Console.ReadLine());

            int colsCnt = 1;
         
            for (int row = 0; row < num ; row++)
            {          
                for (int col = 0; col < colsCnt; col++)
                {
                    Console.Write("$ ");
                    
                }
                Console.WriteLine();
                colsCnt++;
            }      
        }
    }
}
