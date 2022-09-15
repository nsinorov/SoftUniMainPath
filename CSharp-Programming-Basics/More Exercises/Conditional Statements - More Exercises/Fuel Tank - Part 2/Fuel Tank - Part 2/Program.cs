using System;

namespace Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double gasolineFoLitter = 2.22;
            double dieselForLitter = 2.33;
            double gasForLitter = 0.93;

            string cardForDiscount = string.Empty;
            double endPrice = 0;

            string typeOfFuel = Console.ReadLine();
            double quantityOfFuel = double.Parse(Console.ReadLine());
            string cardDiscount = Console.ReadLine(); // Yes or No

            if(cardDiscount == "Yes")
            {
                if(typeOfFuel == "Gasoline")
                {
                    double discountForGasoline = gasolineFoLitter - 0.18;
                    endPrice = quantityOfFuel * discountForGasoline;
                }
                else if(typeOfFuel == "Diesel")
                {
                    double discountForDiesel = dieselForLitter - 0.12;
                    endPrice = quantityOfFuel * discountForDiesel;
                }
                else if(typeOfFuel == "Gas")
                {

                    double discountForGas = gasForLitter - 0.08;
                    endPrice = quantityOfFuel * discountForGas;
                }     
            }

            if(cardDiscount == "No")
            {
                if(typeOfFuel == "Gasoline")
                {
                    endPrice = quantityOfFuel * gasolineFoLitter;
                }
                else if(typeOfFuel == "Diesel")
                {
                    endPrice = quantityOfFuel * dieselForLitter;
                }
                else if(typeOfFuel == "Gas")
                {
                    endPrice = quantityOfFuel * gasForLitter;
                }            
            }
   
            if(quantityOfFuel >= 20 && quantityOfFuel <= 25)
            {
                endPrice = endPrice - (endPrice * 0.08); 
            }
            else if(quantityOfFuel > 25)
            {
                endPrice = endPrice - (endPrice * 0.1);
            }      

            Console.WriteLine($"{endPrice:F2} lv.");
        }
    }
}
