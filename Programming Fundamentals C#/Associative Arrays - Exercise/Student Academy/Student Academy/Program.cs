using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            var students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();               
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                double studentGrade = student.Value.Average();

                if(studentGrade >= 4.5)
                {
                    Console.WriteLine($"{studentName} -> {studentGrade:F2}");
                }
            }
        }
    }
}
