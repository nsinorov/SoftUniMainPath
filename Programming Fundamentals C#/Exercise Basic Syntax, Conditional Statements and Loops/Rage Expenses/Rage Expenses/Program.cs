using System;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetExpenses = lostGames / 2;
            double mouseExpenses = lostGames / 3;
            double keyboardExpenses = lostGames / 6;
            double displayExpenses = lostGames / 12;

            double expenses = (headsetExpenses * headsetPrice) + (mouseExpenses * mousePrice) + (keyboardExpenses * keyboardPrice) + (displayExpenses * displayPrice) ;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");

        }
    }
}
