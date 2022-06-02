using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> originalList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] operations = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = operations[0];

                if (action == "Add")
                {
                    int number = int.Parse(operations[1]);

                    originalList.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(operations[1]);
                    int index = int.Parse(operations[2]);

                    if (index < 0 || index >= originalList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        originalList.Insert(index, number);
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(operations[1]);

                    if (index < 0 || index >= originalList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        originalList.RemoveAt(index);
                    }
                }
                else if (action == "Shift")
                {
                    string direction = operations[1];
                    int count = int.Parse(operations[2]);

                    Shift(originalList, count, direction);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", originalList));
        }

        static void Shift(List<int> numbers, int numberOfShifts, string direction)
        {
            for (int i = 0; i < numberOfShifts; i++)
            {
                if (direction == "left")
                {
                    int firstElement = numbers[0];

                    for (int j = 0; j < numbers.Count - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }

                    numbers[numbers.Count - 1] = firstElement;
                }
                else if (direction == "right")
                {
                    int lastElement = numbers[numbers.Count - 1];

                    for (int j = numbers.Count - 1; j > 0; j--)
                    {
                        numbers[j] = numbers[j - 1];
                    }

                    numbers[0] = lastElement;
                }
            }
        }
    }
}
