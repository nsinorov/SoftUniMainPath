using System;

namespace Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

           int result = Add(num1, num2);
            Substract(result, num3);
        }
         static void Substract(int result, int num3) => Console.WriteLine(result - num3);
        static int Add(int num1, int num2) => num1 + num2;    
    }
}
