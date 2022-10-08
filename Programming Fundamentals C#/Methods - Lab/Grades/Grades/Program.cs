using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            checkGrade(grade);
        }

        private static void checkGrade(double grade)
        {
            string result = grade >= 2.00 && grade <= 2.99 ? "Fail" :
                            grade >= 3.00 && grade <= 3.49 ? "Poor" :
                            grade >= 3.50 && grade <= 4.49 ? "Good" :
                            grade >= 4.50 && grade <= 5.49 ? "Very good" :
                            grade >= 5.50 && grade <= 6.00 ? "Excellent" : "Invalid grade";

            Console.WriteLine(result);
        }
    }
}
