using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "Yohoho!")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Loot")
                {
                    Loot(inventory, cmdArgs);
                }
                else if (action == "Drop")
                {
                    int indexToDrop = int.Parse(cmdArgs[1]);
                    Drop(inventory, indexToDrop);
                }
                else if (action == "Steal")
                {
                    int count = int.Parse(cmdArgs[1]);
                    Steal(inventory, count);
                }

                command = Console.ReadLine();
            }

            PrintTreasureGain(inventory);
        }

        static void Loot(List<string> inventory, string[] loot)
        {
            for (int i = 1; i < loot.Length; i++)
            {
                string currLoot = loot[i];

                if (!inventory.Contains(currLoot))
                {
                    inventory.Insert(0, currLoot);
                }
            }
        }

        static void Drop(List<string> inventory, int index)
        {
            if (index < 0 || index >= inventory.Count)
            {
                return;
            }

            string itemToDrop = inventory[index];
            inventory.RemoveAt(index);
            inventory.Add(itemToDrop);
        }

        static void Steal(List<string> inventory, int count)
        {
            List<string> stolenItems = new List<string>();

            if (count > inventory.Count)
            {
                count = inventory.Count;
            }

            for (int i = 0; i < count; i++)
            {
                stolenItems.Add(inventory.Last());
                inventory.RemoveAt(inventory.Count - 1);
            }

            stolenItems.Reverse();
            Console.WriteLine(string.Join(", ", stolenItems));
        }

        static void PrintTreasureGain(List<string> inventory)
        {
            if (inventory.Count > 0)
            {
                double averageGain = 0;
                foreach (string item in inventory)
                {
                    averageGain += item.Length;
                }

                averageGain /= inventory.Count;

                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
