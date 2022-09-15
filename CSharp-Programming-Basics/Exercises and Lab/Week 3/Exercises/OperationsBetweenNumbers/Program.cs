using System;

namespace Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int num1 = int.Parse(Console.ReadLine());
           int num2 = int.Parse(Console.ReadLine());
            char opeation = char.Parse(Console.ReadLine());       

            if (opeation == '+' || opeation == '-' || opeation == '*')
            {
                int result = 0;
                string evenOrOdd = "even";

                switch (opeation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                        case '-':
                        result = num1 - num2;
                        break;
                        default:
                      result =  num1* num2;
                        break;
                }

                if( result %2!= 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {opeation} {num2} = {result} - {evenOrOdd}");
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if (opeation == '/')
                {
                    double result = 1.0*num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:F2}");
                }
                else
                {
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                }
            }
        }
    }
}
