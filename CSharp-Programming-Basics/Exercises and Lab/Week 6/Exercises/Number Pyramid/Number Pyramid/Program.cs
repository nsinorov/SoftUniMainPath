using System;

namespace Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int currentNum = 1;
          
            for(int i = 1; i <=num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNum+ " ");      
                    currentNum++;
                    if (currentNum > num)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (currentNum > num)
                {
                    break;
                }           
            }
        }
    }
}
