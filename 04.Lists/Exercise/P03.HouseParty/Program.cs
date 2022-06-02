using System;
using System.Collections.Generic;

namespace P03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> invitedPeople = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                string[] commandElements = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string currentPerson = commandElements[0];

                if (commandElements[2] == "not")
                {
                    if (invitedPeople.Contains(currentPerson))
                    {
                        invitedPeople.Remove(currentPerson);
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson} is not in the list!");
                    }
                }
                else
                {
                    if (invitedPeople.Contains(currentPerson))
                    {
                        Console.WriteLine($"{currentPerson} is already in the list!");
                    }
                    else
                    {
                        invitedPeople.Add(currentPerson);
                    }
                }
            }

            foreach (var person in invitedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
