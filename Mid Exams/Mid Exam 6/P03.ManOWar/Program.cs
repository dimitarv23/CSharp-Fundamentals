using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> warShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int healthCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "Retire")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Fire")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int damage = int.Parse(cmdArgs[2]);
                    Fire(warShip, index, damage);
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int damage = int.Parse(cmdArgs[3]);
                    Defend(pirateShip, startIndex, endIndex, damage);
                }
                else if (action == "Repair")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int health = int.Parse(cmdArgs[2]);
                    Repair(pirateShip, index, health, healthCapacity);
                }
                else if (action == "Status")
                {
                    Status(pirateShip, healthCapacity);
                }

                command = Console.ReadLine();
            }

            PrintStatusesOfShips(pirateShip, warShip);
        }

        static void Fire(List<int> warShip, int index, int damage)
        {
            if (index < 0 || index >= warShip.Count)
            {
                return;
            }

            warShip[index] -= damage;

            if (warShip[index] <= 0)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
                Environment.Exit(0);
            }
        }

        static void Defend(List<int> pirateShip, int startIndex, int endIndex, int damage)
        {
            if (startIndex < 0 || endIndex >= pirateShip.Count)
            {
                return;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                pirateShip[i] -= damage;

                if (pirateShip[i] <= 0)
                {
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    Environment.Exit(0);
                }
            }
        }

        static void Repair(List<int> pirateShip, int index, int health, int healthCapacity)
        {
            if (index < 0 || index >= pirateShip.Count)
            {
                return;
            }

            pirateShip[index] += health;

            if (pirateShip[index] > healthCapacity)
            {
                pirateShip[index] = healthCapacity;
            }
        }

        static void Status(List<int> pirateShip, int healthCapacity)
        {
            int sectionsNeedingRepair = 0;

            foreach (var section in pirateShip)
            {
                if (section < 0.2 * healthCapacity)
                {
                    sectionsNeedingRepair++;
                }
            }

            Console.WriteLine($"{sectionsNeedingRepair} sections need repair.");
        }

        static void PrintStatusesOfShips(List<int> pirateShip, List<int> warShip)
        {
            int pirateShipStatus = 0;
            foreach (var section in pirateShip)
            {
                pirateShipStatus += section;
            }

            int warShipStatus = 0;
            foreach (var section in warShip)
            {
                warShipStatus += section;
            }

            Console.WriteLine($"Pirate ship status: {pirateShipStatus}");
            Console.WriteLine($"Warship status: {warShipStatus}");
        }
    }
}
