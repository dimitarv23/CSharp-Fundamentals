using System;
using System.Collections.Generic;

namespace P03.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();
            while (command != "Sail")
            {
                string[] cmdArgs = command
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);

                if (cities.ContainsKey(cityName))
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += gold;
                }
                else
                {
                    cities.Add(cityName, new List<int> { population, gold });
                }

                command = Console.ReadLine();
            }

            string command2 = Console.ReadLine();
            while (command2 != "End")
            {
                string[] cmdArgs = command2
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Plunder")
                {
                    string town = cmdArgs[1];
                    int people = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);

                    Plunder(cities, town, people, gold);
                }
                else if (action == "Prosper")
                {
                    string town = cmdArgs[1];
                    int gold = int.Parse(cmdArgs[2]);

                    Prosper(cities, town, gold);
                }

                command2 = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to: ");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        static void Plunder(Dictionary<string, List<int>> cities, string town, int people, int gold)
        {
            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

            cities[town][0] -= people;
            cities[town][1] -= gold;

            if (cities[town][0] <= 0 || cities[town][1] <= 0)
            {
                cities.Remove(town);
                Console.WriteLine($"{town} has been wiped off the map!");
            }
        }

        static void Prosper(Dictionary<string, List<int>> cities, string town, int gold)
        {
            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
                return;
            }

            cities[town][1] += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
        }
    }
}
