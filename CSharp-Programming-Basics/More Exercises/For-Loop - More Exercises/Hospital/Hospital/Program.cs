using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int daysForCalc = int.Parse(Console.ReadLine());
         
            int doctors = 7;
            int treated = 0;
            int notTreated = 0;      

            for (int counter = 1; counter <= daysForCalc; counter++)
            {

                if (counter % 3 == 0 && notTreated > treated)
                {                           
                   doctors++;                            
                }

                int patients = int.Parse(Console.ReadLine());

                if (doctors < patients)
                {
                      treated += doctors;
                    notTreated += patients - doctors;
                }
                else
                {
                    treated += patients;       
                }           

            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {notTreated}.");
        }
    }
}
