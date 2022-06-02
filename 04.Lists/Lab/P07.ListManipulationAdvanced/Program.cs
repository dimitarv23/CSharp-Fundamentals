using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            bool hasOriginalListChanged = false;

            while (input != "end")
            {
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];

                if (action == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Add(number);

                    hasOriginalListChanged = true;
                }
                else if (action == "Remove")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Remove(number);

                    hasOriginalListChanged = true;
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);
                    numbers.RemoveAt(index);

                    hasOriginalListChanged = true;
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    numbers.Insert(index, number);

                    hasOriginalListChanged = true;
                }
                else if (action == "Contains")
                {
                    int number = int.Parse(commands[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (action == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (action == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (action == "Filter")
                {
                    string condition = commands[1];
                    int conditionNumber = int.Parse(commands[2]);

                    Console.WriteLine(string.Join(" ", Filter(numbers, condition, conditionNumber)));
                }

                input = Console.ReadLine();
            }

            if (hasOriginalListChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static List<int> Filter(List<int> numbers, string condition, int number)
        {
            List<int> filteredList = new List<int>();

            if (condition == "<")
            {
                filteredList.AddRange(numbers.Where(x => x < number));
            }
            else if (condition == ">")
            {
                filteredList.AddRange(numbers.Where(x => x > number));
            }
            else if (condition == "<=")
            {
                filteredList.AddRange(numbers.Where(x => x <= number));
            }
            else if (condition == ">=")
            {
                filteredList.AddRange(numbers.Where(x => x >= number));
            }

            return filteredList;
        }
    }
}
