using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "Go Shopping!")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string item = cmdArgs[1];

                if (action == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (action == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (action == "Correct")
                {
                    string newItem = cmdArgs[2];

                    if (groceries.Contains(item))
                    {
                        int indexToCorrect = groceries.IndexOf(item);
                        groceries[indexToCorrect] = newItem;
                    }
                }
                else if (action == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
