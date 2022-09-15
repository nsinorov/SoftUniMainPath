using System;

namespace Numbers_Divided_by_3_Without_Reminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 100; counter++)
            {
                if(counter % 3 == 0)
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
