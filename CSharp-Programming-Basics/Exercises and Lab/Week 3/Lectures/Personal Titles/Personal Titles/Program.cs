using System;

namespace Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            bool isOfAge = age < 16;

            if ( gender == "f")
            {
                if (isOfAge)
                {
                    Console.WriteLine("Miss");
                }
               else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (isOfAge)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }              
        }
    }
}
