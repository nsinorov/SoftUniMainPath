using System;

namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfInput = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (typeOfInput == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);

                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);

            }
            else if (typeOfInput == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);

                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (typeOfInput == "string")
            {
               string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);

            if (result > 0)
            {
                return a;
            }
            return b;
        }
    }
}
