using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courseInfo = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] input = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                var courseName = input[0];
                var studentName = input[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }
                courseInfo[courseName].Add(studentName);

                command = Console.ReadLine();
            }
            PrintCourseInfo(courseInfo);
        }
        static void PrintCourseInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                var students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");

                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
