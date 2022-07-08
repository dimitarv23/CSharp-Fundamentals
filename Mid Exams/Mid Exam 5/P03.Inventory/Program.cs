using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "Craft!")
            {
                string[] cmdArgs = command
                    .Split(new string[] { " - ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string item = cmdArgs[1];

                if (action == "Collect")
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }
                else if (action == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }
                else if (action == "Combine Items")
                {
                    if (inventory.Contains(item))
                    {
                        string newItem = cmdArgs[2];
                        int indexToCombine = inventory.IndexOf(item) + 1;
                        inventory.Insert(indexToCombine, newItem);
                    }
                }
                else if (action == "Renew")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
