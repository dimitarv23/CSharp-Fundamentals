using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);


                if (action == "Shoot")
                {
                    int power = int.Parse(cmdArgs[2]);

                    Shoot(targets, index, power);
                }
                else if (action == "Add")
                {
                    int value = int.Parse(cmdArgs[2]);

                    Add(targets, index, value);
                }
                else if (action == "Strike")
                {
                    int radius = int.Parse(cmdArgs[2]);

                    Strike(targets, index, radius);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
        static void Shoot(List<int> targets, int index, int power)
        {
            //If the given index is invalid
            if (index < 0 || index >= targets.Count)
            {
                return;
            }

            if (targets[index] - power <= 0)
            {
                targets.RemoveAt(index);
            }
            else
            {
                targets[index] -= power;
            }
        }

        static void Add(List<int> targets, int index, int value)
        {
            //If the given index is invalid
            if (index < 0 || index >= targets.Count)
            {
                Console.WriteLine("Invalid placement!");
                return;
            }

            targets.Insert(index, value);
        }

        static void Strike(List<int> targets, int index, int radius)
        {
            //If the given index is invalid or the radius goes outside of the list
            if (index < 0 || index >= targets.Count)
            {
                return;
            }
            if (index - radius < 0 || index + radius >= targets.Count)
            {
                Console.WriteLine("Strike missed!");
                return;
            }

            int indexToRemove = index - radius;

            for (int i = index - radius; i <= index + radius; i++)
            {
                targets.RemoveAt(indexToRemove);
            }
        }
    }
}
