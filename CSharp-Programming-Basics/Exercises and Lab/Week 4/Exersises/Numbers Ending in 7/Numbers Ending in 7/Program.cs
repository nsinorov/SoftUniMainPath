using System;

namespace Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            for(int i = 1; i <= 997; i++)
            {
                if(i % 10 == 7)
                {
                    Console.WriteLine(i);
                }           
            }
        }
    }
}
