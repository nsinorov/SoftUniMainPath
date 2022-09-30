using System;

namespace Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int openCount = 0;
            int closeCount = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openCount++;
                }

                if (input == ")")
                {
                    closeCount++;

                    if (openCount - closeCount != 0)
                    {
                        break;
                    }
                }
            }
           string result = openCount == closeCount ? "BALANCED" : "UNBALANCED";
           Console.WriteLine(result);
        }
    }
}
