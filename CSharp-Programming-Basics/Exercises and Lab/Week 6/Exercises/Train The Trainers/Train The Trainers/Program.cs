using System;

namespace Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfJourie = int.Parse(Console.ReadLine());

            string nameOfPresentation = Console.ReadLine();

            double presentationSum;
            int countOfPresentations = 0;
            double sumOfAllPresentationScore = 0;

            while(nameOfPresentation != "Finish")
            {
                presentationSum = 0;

                for (int i = 1; i <= numOfJourie; i++)
                {
                    presentationSum += double.Parse(Console.ReadLine());
                }

                presentationSum = presentationSum / numOfJourie;
                Console.WriteLine($"{nameOfPresentation} - {presentationSum:F2}.");

                sumOfAllPresentationScore += presentationSum;
                countOfPresentations++;

                nameOfPresentation = Console.ReadLine();

            }

            sumOfAllPresentationScore = sumOfAllPresentationScore / countOfPresentations;

            Console.WriteLine($"Student's final assessment is {sumOfAllPresentationScore:F2}.");
        }
    }
}
