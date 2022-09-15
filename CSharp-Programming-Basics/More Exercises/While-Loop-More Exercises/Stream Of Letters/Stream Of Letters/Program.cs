using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conword = "";
            string theword = "";
            string input;
            char inputChar;
            string tempword = "";

            while ((input = Console.ReadLine()) != "End")
            {
                inputChar = input[0];

                if (!((inputChar >= 'a' && inputChar <= 'z') || (inputChar >= 'A' && inputChar <= 'Z')))
                {
                    continue;
                }

                switch (input)
                {
                    case "c":
                        tempword += conword.Contains("c") ? input : string.Empty;
                        conword += !conword.Contains("c") ? input : string.Empty;
                        break;
                    case "o":
                        tempword += conword.Contains("o") ? input : string.Empty;
                        conword += conword.Contains("o") ? string.Empty : input;
                        break;
                    case "n":
                        tempword += conword.Contains("n") ? input : string.Empty;
                        conword += conword.Contains("n") ? string.Empty : input;
                        break;
                    default:
                        tempword += input;
                        break;
                }
                if (conword.Length == 3)
                {
                    conword = string.Empty;
                    theword += $"{tempword} ";
                    tempword = string.Empty;
                }
            }

            Console.WriteLine(theword);
        }
    }
}