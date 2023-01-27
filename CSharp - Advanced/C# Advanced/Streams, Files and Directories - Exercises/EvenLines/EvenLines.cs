namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            string result = string.Empty;

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int lineNumber = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (lineNumber % 2 == 0)
                    {
                        line = Regex.Replace(line, "[-.!?,]", "@");

                        string[] words = line.Split(' ');

                        Array.Reverse(words);

                        line = string.Join(" ", words);

                        result += line + "\n";                     
                    }
                    lineNumber++;
                }

            }
            return result;
        }
    }
}

