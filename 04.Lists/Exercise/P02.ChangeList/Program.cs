using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
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
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];
                int element = int.Parse(commands[1]);

                if (action == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (action == "Insert")
                {
                    int position = int.Parse(commands[2]);

                    numbers.Insert(position, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
