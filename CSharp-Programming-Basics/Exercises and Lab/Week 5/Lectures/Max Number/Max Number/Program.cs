using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();       
            int minNum = int.MaxValue;
    
            while (word != "Stop")
            {       
              int num = int.Parse(word);
                if(num < minNum)
                {
                    minNum = num;
                }
                word = Console.ReadLine();                           
            }
            Console.WriteLine(minNum);
        }
    }
}
