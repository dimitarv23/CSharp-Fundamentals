using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ListManipulationBasics
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

            while (input != "end")
            {
                string[] commands = input.Split();
                string action = commands[0];

                if (action == "Add")
                {
                    int number = int.Parse(commands[1]);

                    numbers.Add(number);
                }
                else if (action == "Remove")
                {
                    int number = int.Parse(commands[1]);

                    numbers.Remove(number);
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);

                    numbers.RemoveAt(index);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    numbers.Insert(index, number);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
