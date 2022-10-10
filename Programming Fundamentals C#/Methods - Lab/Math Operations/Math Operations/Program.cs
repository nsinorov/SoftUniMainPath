using System;

namespace Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;
            
            result = Add(num1, operation, num2, result);
            result = Substract(num1, operation, num2, result);
            result = Multiply(num1, operation, num2, result);
            result = Divided(num1, operation, num2, result);

            Console.WriteLine(result);
        }

         static int Divided(int num1, string operation, int num2, int result)
        {
            if (operation == "/")
            {
                result = num1 / num2;
            }

            return result;
        }

         static int Multiply(int num1, string operation, int num2, int result)
        {
            if (operation == "*")
            {
                result = num1 * num2;
            }

            return result;
        }

         static int Substract(int num1, string operation, int num2, int result)
        {
            if (operation == "-")
            {
                result = num1 - num2;
            }

            return result;
        }

         static int Add(int num1, string operation, int num2, int result)
        {
            if (operation == "+")
            {
                result = num1 + num2;
            }

            return result;
        }
    }
}
