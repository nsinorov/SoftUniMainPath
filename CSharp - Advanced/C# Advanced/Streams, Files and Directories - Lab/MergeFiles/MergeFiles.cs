namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader lines = new StreamReader(firstInputFilePath))
            {
                using (StreamReader linesTwo = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string[] readFirst = File.ReadAllLines(firstInputFilePath);
                        string[] readSecond = File.ReadAllLines(secondInputFilePath);

                        for (int i = 0; i < readFirst.Length; i++) 
                        {                      
                            writer.WriteLine(string.Join(" ", readFirst[i]));
                            writer.WriteLine(string.Join(" ", readSecond[i]));
                        }
                    }
                }
            }
        }
    }
}
