using System;
using System.Collections.Generic;
using System.Linq;

namespace P06StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Box> boxList = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split();
                string searialNumber = inputArr[0];
                string itemName = inputArr[1];
                int itemQuantity = int.Parse(inputArr[2]);
                decimal itemPrice = decimal.Parse(inputArr[3]);
                decimal priceForBox = itemQuantity * itemPrice;
                Item newItem = new Item(itemName, itemPrice);
                Box newBox = new Box(searialNumber, newItem, itemQuantity, priceForBox);
                boxList.Add(newBox);
            }

            foreach (var box in boxList.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
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
        public Box(string serialNumber, Item item, int itemQuantity, decimal priceForBox)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForBox = priceForBox;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox { get; set; }
    }
}
