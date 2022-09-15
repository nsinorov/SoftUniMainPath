using System;

namespace Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int failedGrades = int.Parse(Console.ReadLine());

            int countBadGrades = 0;
            int countSolvedProb = 0;
            double sumOfAllGrades = 0;
            string lastprob = string.Empty;
            bool isFailed = true;

                
            while(countBadGrades < failedGrades)
            {
                string problemName = Console.ReadLine();    
                if(problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if(grade <= 4)
                {
                    countBadGrades++;
                }
                sumOfAllGrades += grade;
                countSolvedProb++;
                lastprob = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumOfAllGrades / countSolvedProb:F2}");
                Console.WriteLine($"Number of problems: {countSolvedProb}");
                Console.WriteLine($"Last problem: {lastprob}");
            }
        }
    }
}
