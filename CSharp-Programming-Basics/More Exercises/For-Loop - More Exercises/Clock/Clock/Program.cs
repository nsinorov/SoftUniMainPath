using System;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args) //// задачата първо беше да се направи часовник за часове и мин, 2ра част добавих и секундите
        {                   
            for (int hours = 0; hours <= 23; hours++)
            {         
                for (int min = 0; min <= 59; min++)
                {
                    for (int sec = 0; sec <= 59; sec++)
                    {
                        Console.WriteLine($"{hours} : {min} : {sec}");
                    }   
                }
            }
        }
    }
}
