using System;

namespace P02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonRooms = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            int coins = 0;

            foreach (string room in dungeonRooms)
            {
                string[] roomArgs = room
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = roomArgs[0];
                int amount = int.Parse(roomArgs[1]);

                if (action == "potion")
                {
                    Heal(ref health, amount);
                }
                else if (action == "chest")
                {
                    coins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    string monsterName = action;
                    health -= amount;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monsterName}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {Array.IndexOf(dungeonRooms, room) + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {coins}");
            Console.WriteLine($"Health: {health}");
        }

        static void Heal(ref int health, int amount)
        {
            int hpToHeal = amount;

            if (health + amount > 100)
            {
                hpToHeal = 100 - health;
            }

            health += hpToHeal;
            Console.WriteLine($"You healed for {hpToHeal} hp.");
            Console.WriteLine($"Current health: {health} hp.");
        }
    }
}
