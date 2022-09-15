using System;

namespace Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfDetergent = int.Parse(Console.ReadLine());

            int quantitiOfDetergent = numOfDetergent * 750;
            int plateMl = 5;
            int potMl = 15;
            int plateCount = 0;
            int potsCount = 0;
            int numOfWashes = 0;
        
            string command = null;

            while(quantitiOfDetergent >= 0 && (command = Console.ReadLine()) != "End")
            {
                numOfWashes++;

                int input = int.Parse(command);

                if(numOfWashes % 3 == 0)
                {
                    potsCount += input;
                    input *= potMl;
                    quantitiOfDetergent -= input;
                    numOfWashes = 0;

                }
                else
                {
                    plateCount += input;
                    input *= plateMl;
                    quantitiOfDetergent -= input;
                }                         
            }      

            if(quantitiOfDetergent >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{plateCount} dishes and {potsCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {quantitiOfDetergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(quantitiOfDetergent)} ml. more necessary!");
            }
        }
    }
}
