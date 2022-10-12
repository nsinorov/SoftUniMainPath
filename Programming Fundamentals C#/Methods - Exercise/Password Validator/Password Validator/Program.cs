using System;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();
            bool isPasswordBetweenNums = ValidatePasswordLenght(input);
            bool isPasswordContainsValidSym = ValidatePasswordText(input);
            bool isPasswordAtleastTwoNums = ValidatePasswordDigits(input);
        
            if(!isPasswordBetweenNums)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordContainsValidSym)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isPasswordAtleastTwoNums)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPasswordAtleastTwoNums && isPasswordAtleastTwoNums && isPasswordContainsValidSym)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ValidatePasswordDigits(string input)
        {
            int count = 0;

            foreach (char symbols in input)
            {
                if (char.IsDigit(symbols))
                {
                    count++;
                }
            }
            return count >= 2;
        }

        private static bool ValidatePasswordText(string input)
        {
            foreach (char symbol in input)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidatePasswordLenght(string input)
        {
           return input.Length >= 6 && input.Length <= 10;
        }
    }
}
