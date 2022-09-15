using System;

namespace Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double turns = int.Parse(Console.ReadLine());

            double points = 0;          
            double from0To9 = 0;
            double from10To19 = 0;
            double from20To29 = 0;
            double from30To39 = 0;
            double from40To50 = 0;
            double invalidNums = 0;

            for (double counter = 0; counter < turns; counter++)
            {

                double currNum = double.Parse(Console.ReadLine());

                if (currNum >= 0 && currNum <= 9)
                {
                    points = (0.2 * currNum ) + points;                 
                    from0To9++;
                }
                else if(currNum >= 10 && currNum <= 19)
                {
                    points = (0.3 * currNum ) + points;                 
                    from10To19++;
                }
                else if (currNum >= 20 && currNum <= 29)
                {
                    points = (0.4 * currNum ) + points;                
                    from20To29++;
                }
                else if (currNum >= 30 && currNum <= 39)
                {
                    points += 50;                  
                    from30To39++;
                }
                else if (currNum >= 40 && currNum <= 50)
                {
                    points += 100;               
                    from40To50++;
                }

                if(currNum < 0 || currNum > 50)
                {
                    points = points / 2;                                 
                    invalidNums++;
                }                    
            }
         
            from0To9 = from0To9  / turns * 100;
            from10To19 = from10To19  / turns * 100;
            from20To29 = from20To29 / turns * 100;
            from30To39 = from30To39 / turns * 100;
            from40To50 = from40To50  / turns * 100;
            invalidNums = invalidNums  / turns * 100;

            Console.WriteLine($"{points:F2}");
            Console.WriteLine($"From 0 to 9: {from0To9:F2}%");
            Console.WriteLine($"From 10 to 19: {from10To19:F2}%");
            Console.WriteLine($"From 20 to 29: {from20To29:F2}%");
            Console.WriteLine($"From 30 to 39: {from30To39:F2}%");
            Console.WriteLine($"From 40 to 50: {from40To50:F2}%");
            Console.WriteLine($"Invalid numbers: {invalidNums:F2}%");

        }
    }
}
