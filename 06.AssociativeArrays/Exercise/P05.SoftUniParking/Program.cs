using System;
using System.Collections.Generic;

namespace P05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersAndCars = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string username = cmdArgs[1];

                if (action == "register")
                {
                    string licensePlate = cmdArgs[2];

                    if (usersAndCars.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {usersAndCars[username]}");
                        continue;
                    }

                    usersAndCars.Add(username, licensePlate);
                    Console.WriteLine($"{username} registered {licensePlate} successfully");
                }
                else if (action == "unregister")
                {
                    if (!usersAndCars.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }

                    usersAndCars.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }

            foreach (var item in usersAndCars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
