using System;

namespace Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string file = input[input.Length - 1];
            string[] splitLastWord = file.Split(".");
            string fileName = splitLastWord[0];
            string extension = splitLastWord[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
