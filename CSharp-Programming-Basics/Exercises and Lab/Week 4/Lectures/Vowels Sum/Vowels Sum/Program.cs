using System;

namespace Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int lenght = text.Length;
            int sum = 0;

            for (int i = 0; i < lenght; i++)
            {
                char currentLetter = text[i];
                switch (currentLetter)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
