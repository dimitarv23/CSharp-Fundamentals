using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> peopleInWagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxPeoplePerWagon = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Add")
                {
                    int peopleInNextWagon = int.Parse(commands[1]);

                    peopleInWagons.Add(peopleInNextWagon);
                }
                else
                {
                    int newPassengers = int.Parse(commands[0]);

                    for (int i = 0; i < peopleInWagons.Count; i++)
                    {
                        if (peopleInWagons[i] + newPassengers <= maxPeoplePerWagon)
                        {
                            peopleInWagons[i] += newPassengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", peopleInWagons));
        }
    }
}
