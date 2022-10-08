using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int resultAfterOp = 0;

            resultAfterOp = add(operation, num1, num2, resultAfterOp);
            resultAfterOp = multiply(operation, num1, num2, resultAfterOp);
            resultAfterOp = substract(operation, num1, num2, resultAfterOp);
            resultAfterOp = divide(operation, num1, num2, resultAfterOp);

            Console.WriteLine(resultAfterOp);
        }

         static int divide(string operation, int num1, int num2, int resultAfterOp)
        {
            if (operation == "divide")
            {
                resultAfterOp = num1 / num2;
            }
            return resultAfterOp;
        }
         static int substract(string operation, int num1, int num2, int resultAfterOp)
        {
            if (operation == "substract")
            {
                resultAfterOp = num1 - num2;
            }
            return resultAfterOp;
        }

         static int multiply(string operation, int num1, int num2, int resultAfterOp)
        {
            if (operation == "multiply")
            {
                resultAfterOp = num1 * num2;
            }
            return resultAfterOp;
        }

        static int add(string operation, int num1, int num2, int resultAfterOp)
        {
            if (operation == "add")
            {
                resultAfterOp = num1 + num2;
            }
            return resultAfterOp;
        }
    }
}
