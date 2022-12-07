using System;
using System.Linq;
using System.Text;

namespace StringManipulator
{
    class Program
    {
        static void Main()
        {
            var input = string.Empty;
            var temp = string.Empty;

            var result = Console.ReadLine();

            var builder = new StringBuilder();

            while ((input = Console.ReadLine()) != "End")
            {
                var inputArr = input.Split();
                var command = inputArr[0];

                // We check if it's => "Translate"
                if (command == "Translate")
                {
                    var charToReplace = char.Parse(inputArr[1]);
                    var replacement = char.Parse(inputArr[2]);
                    result = result.Replace(charToReplace, replacement);
                    builder.AppendLine(result);
                }

                // We check if it's => "Includes"
                else if (command == "Includes")
                {
                    var checkIfExists = inputArr[1];

                    if (result.Contains(checkIfExists))
                    {
                        builder.AppendLine("True");
                    }
                    else
                    {
                        builder.AppendLine("False");
                    }
                }

                // We check if it's => "Start"
                else if (command == "Start")
                {
                    var check = inputArr[1];
                    var checkLength = inputArr[1].Length;
                    var temporary = string.Empty;

                    for (int j = 0; j < check.Length; j++)
                    {
                        temporary += result[j];
                    }
                    if (temporary == check)
                    {
                        builder.AppendLine("True");
                    }
                    else
                    {
                        builder.AppendLine("False");
                    }
                }

                // We check if it's => "Lowercase"
                else if (command == "Lowercase")
                {
                    result = result.ToLower();
                    builder.AppendLine($"{result}");
                }

                // We check if it's => "FindIndex"
                else if (command == "FindIndex")
                {
                    var charToFind = inputArr[1];
                    var lastIndex = result.LastIndexOf(charToFind);
                    builder.AppendLine($"{lastIndex}");
                }

                // We check if it's => "Remove"
                else if (command == "Remove")
                {
                    var startIndex = int.Parse(inputArr[1]);
                    var count = int.Parse(inputArr[2]);
                    result = result.Remove(startIndex, count);
                    builder.AppendLine($"{result}");
                }
            }
            Console.WriteLine(builder.ToString());
        }
    }
}