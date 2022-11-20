
using System;
using System.Text;

namespace T05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int mulitplier = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            int reminder = 0;
            
            if (mulitplier == 0 || input == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--) 
            {
                int currDigit = int.Parse(input[i].ToString()); 
                int product = currDigit * mulitplier + reminder;
                int result = product % 10; 
                reminder = product / 10;
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}