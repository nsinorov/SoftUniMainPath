using System;

namespace StringEncryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number of strings
            int numStrings = int.Parse(Console.ReadLine());

            // Read the strings and encrypt them
            int[] encryptedStrings = new int[numStrings];
            for (int i = 0; i < numStrings; i++)
            {
                string str = Console.ReadLine();

                int encryptedString = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    char c = str[j];
                    if (IsVowel(c))
                    {
                        encryptedString += (int)c * str.Length;
                    }
                    else
                    {
                        encryptedString += (int)c / str.Length;
                    }
                }
                encryptedStrings[i] = encryptedString;
            }

            // Sort the encrypted strings in ascending order
            Array.Sort(encryptedStrings);

            // Print the encrypted strings
            foreach (int encryptedString in encryptedStrings)
            {
                Console.WriteLine(encryptedString);
            }
        }

        static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
