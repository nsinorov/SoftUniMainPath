namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {

            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using StreamReader readerOne = new StreamReader(textFilePath);
            {
                using StreamReader readerTwo = new StreamReader(wordsFilePath);
                {
                    using StreamWriter writer = new StreamWriter(outputFilePath);
                    {
                        string[] wordsList = readerTwo.ReadLine().Split();

                        while (!readerOne.EndOfStream)
                        {
                            var line = readerOne.ReadLine().ToLower();

                            for (int i = 0; i < wordsList.Length; i++)
                            {
                                var word = wordsList[i].ToString().ToLower();

                                if (line.Contains(word))
                                {
                                    if (!words.ContainsKey(word))
                                    {
                                        words[word] = 0;
                                    }
                                    words[word]++;
                                }
                            }
                        }
                        words = words.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                        foreach (var word in words)
                        {
                            writer.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }              
            }                
        }
    }
}
