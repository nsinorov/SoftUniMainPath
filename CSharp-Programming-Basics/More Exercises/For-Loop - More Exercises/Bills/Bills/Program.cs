using System;

namespace Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int waterMonth = 20;
            int ethernetMonth = 15;
            double otherBills = 0;
         
            double electricityBill = 0;
            double waterBill = 0;
            double ethernetBill = 0;
            double average = 0;
            
            int numOfMonths = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < numOfMonths; counter++)
            {

                double priceForElectricity = double.Parse((Console.ReadLine()));

                electricityBill += priceForElectricity;
                waterBill = waterMonth * numOfMonths;
                ethernetBill = ethernetMonth * numOfMonths;
                otherBills += (priceForElectricity + waterMonth + ethernetMonth) * 1.2;            
            }

            average = (electricityBill + waterBill + ethernetBill + otherBills)/numOfMonths;

            Console.WriteLine($"Electricity: {electricityBill:F2} lv");
            Console.WriteLine($"Water: {waterBill:F2} lv");
            Console.WriteLine($"Internet: {ethernetBill:F2} lv");
            Console.WriteLine($"Other: {otherBills:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
