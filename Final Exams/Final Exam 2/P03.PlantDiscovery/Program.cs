using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plants = new Dictionary<string, int>();
            Dictionary<string, List<int>> plantsRatings = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine()
                    .Split("<->");
                string plantName = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (plants.ContainsKey(plantName))
                {
                    plants[plantName] = rarity;
                }
                else
                {
                    plants.Add(plantName, rarity);
                    plantsRatings.Add(plantName, new List<int>());
                }
            }

            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] cmdArgs = command
                    .Split(new[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Rate")
                {
                    string plantName = cmdArgs[1];
                    int rating = int.Parse(cmdArgs[2]);

                    if (plantsRatings.ContainsKey(plantName))
                    {
                        plantsRatings[plantName].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "Update")
                {
                    string plantName = cmdArgs[1];
                    int newRarity = int.Parse(cmdArgs[2]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "Reset")
                {
                    string plantName = cmdArgs[1];

                    if (plantsRatings.ContainsKey(plantName))
                    {
                        plantsRatings[plantName].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition: ");
            foreach (var plant in plants)
            {
                double currAverageRating = 0;

                if (plantsRatings[plant.Key].Count > 0)
                {
                    currAverageRating = plantsRatings[plant.Key].Average();
                }

                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {currAverageRating:f2}");
            }
        }
    }
}
