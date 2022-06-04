using System;
using System.Linq;
using System.Collections.Generic;

namespace P06.StoreBoxes
{
    class Item
    {
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public Box(string serialNumber, string item, double quantity, double price)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = quantity;
            this.Price = price;
        }

        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public double ItemQuantity { get; set; }
        public double Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            List<Item> items = new List<Item>();

            while (input != "end")
            {
                string[] info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string serialNumber = info[0];
                string item = info[1];
                double quantity = double.Parse(info[2]);
                double price = double.Parse(info[3]);

                Item newItem = new Item(item, price);
                Box newBox = new Box(serialNumber, item, quantity, price * quantity);

                boxes.Add(newBox);
                items.Add(newItem);

                input = Console.ReadLine();
            }

            List<Box> sortedBoxes = boxes.OrderBy(x => x.Price).ToList();
            sortedBoxes.Reverse();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.Price / box.ItemQuantity:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }
}
