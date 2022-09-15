using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int numOfStudents = int.Parse(Console.ReadLine());

            double topStudents = 0;
            double veryGoodStudents = 0;
            double goodStudents = 0;
            double badStudents = 0;
            double average = 0;
        
            for (int i = 1; i <= numOfStudents; i++)
            {

                double gradeForCurrStudent = double.Parse(Console.ReadLine());

                if(gradeForCurrStudent >= 2.00 && gradeForCurrStudent <= 2.99)
                {
                    badStudents++;
                }
                else if(gradeForCurrStudent >= 3.00 && gradeForCurrStudent <= 3.99)
                {
                    goodStudents++;
                }
                else if(gradeForCurrStudent >= 4.00 && gradeForCurrStudent <= 4.99)
                {
                    veryGoodStudents++; 

                }
                else if(gradeForCurrStudent >= 5.00)
                {
                    topStudents++;
                }

                average += gradeForCurrStudent / numOfStudents;
            }

            topStudents = topStudents / numOfStudents * 100;
            veryGoodStudents = veryGoodStudents / numOfStudents * 100;
            goodStudents = goodStudents / numOfStudents * 100;
            badStudents = badStudents / numOfStudents * 100;
            
            Console.WriteLine($"Top students: {topStudents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGoodStudents:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {goodStudents:F2}%");
            Console.WriteLine($"Fail: {badStudents:F2}%");
            Console.WriteLine($"Average: {average:F2}");

        }
    }
}
