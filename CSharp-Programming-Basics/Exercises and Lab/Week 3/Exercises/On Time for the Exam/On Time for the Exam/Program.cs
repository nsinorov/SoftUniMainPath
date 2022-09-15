using System;

namespace On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
          int examHour = int.Parse(Console.ReadLine());
          int examMinute = int.Parse(Console.ReadLine());
          int arrivalHour = int.Parse(Console.ReadLine());
          int arrivalMin = int.Parse(Console.ReadLine());

            examMinute = examMinute + examHour * 60;
            arrivalMin = arrivalMin + arrivalHour * 60;

            int difference = examMinute - arrivalMin;

            if(difference < 0)
            {
                Console.WriteLine("Late");
            }
            else if(difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }

            int diffHour = Math.Abs(difference / 60);
            int diffMin = Math.Abs(difference % 60);

            if(difference > 0  && difference <= 59)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }

            else if (difference >= 60)

            {
                if (diffMin < 10)
                {
                    Console.WriteLine($"{diffHour}:0{diffMin} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{diffHour}:{diffMin} hours before the start");
                }

            }

            else if( difference < 0 && difference >= -59)
            {
                Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
            }

            else if (difference <= -60)

            {
                if(diffMin < 10)
                {
                    Console.WriteLine($"{diffHour}:0{diffMin} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{diffHour}:{diffMin} hours after the start");
                }
            }
        }
    }
}
