using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] boxInfo = input.Split();

                string serialNum = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNum, item, itemQuantity);
                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach(var box in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }
    
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }    

        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForABox 
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }
    }
}
