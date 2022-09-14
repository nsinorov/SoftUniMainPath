using System;

namespace Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double termOfDeposit = double.Parse(Console.ReadLine());    
            double yearPercentage = double.Parse(Console.ReadLine());

            double wholePercentage = deposit * yearPercentage;
            double percentageMonth = wholePercentage / 12;

            double sum = deposit + termOfDeposit * ((deposit * yearPercentage * 0.01)  / 12);

            Console.Write(sum);
        }
    }
}
