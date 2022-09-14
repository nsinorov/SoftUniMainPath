using System;

namespace Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //, която изчислява необходимате сума, които Божидара ще трябва да заплати на фирмата 
            // Цената на един кв. м. е 7.61 лв със ДДС
            //нейният двор е доста голям, фирмата изпълнител предлага 18% отстъпка от крайната цена.
            double priceForOneYard = 7.61;
            double discountEnd = 0.18;
            //1. Вход	Кв. метри, които ще бъдат озеленени – реално число в интервала [0.00 … 10000.00] double        
            double yardGreening = double.Parse(Console.ReadLine());
            //Логика
            double wholeYardGreening = yardGreening * priceForOneYard;
            double discountFromTotalSum = discountEnd * wholeYardGreening;
            double calculateFinalPrice = wholeYardGreening - discountFromTotalSum; 
             
            Console.WriteLine($"The final price is: {calculateFinalPrice} lv.");
            Console.Write($"The discount is: {discountFromTotalSum} lv.");          
        }
    }
}
