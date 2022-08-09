using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HeroesOfCodeAndLogic7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] heroInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroInfo[0];
                int hp = int.Parse(heroInfo[1]);
                int mp = int.Parse(heroInfo[2]);

                if (!heroes.ContainsKey(heroName))
                {
                    heroes.Add(heroName, new List<int> { hp, mp });
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArgs = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "CastSpell")
                {
                    string heroName = cmdArgs[1];
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    CastSpell(heroes, heroName, mpNeeded, spellName);
                }
                else if (action == "TakeDamage")
                {
                    string heroName = cmdArgs[1];
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    TakeDamage(heroes, heroName, damage, attacker);
                }
                else if (action == "Recharge")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);

                    Recharge(heroes, heroName, amount);
                }
                else if (action == "Heal")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);

                    Heal(heroes, heroName, amount);
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }

        static void CastSpell(Dictionary<string, List<int>> heroes, string heroName, int mpNeeded, string spellName)
        {
            if (heroes.ContainsKey(heroName))
            {
                int manaPoints = heroes[heroName][1];
                if (manaPoints >= mpNeeded)
                {
                    manaPoints -= mpNeeded;
                    Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {manaPoints} MP!");
                    heroes[heroName][1] = manaPoints;
                }
                else
                {
                    Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                }
            }
        }

        static void TakeDamage(Dictionary<string, List<int>> heroes, string heroName, int damage, string attacker)
        {
            if (heroes.ContainsKey(heroName))
            {
                heroes[heroName][0] -= damage;

                if (heroes[heroName][0] > 0)
                {
                    Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                }
                else
                {
                    Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    heroes.Remove(heroName);
                }
            }
        }

        static void Recharge(Dictionary<string, List<int>> heroes, string heroName, int amount)
        {
            if (heroes.ContainsKey(heroName))
            {
                int heroMp = heroes[heroName][1];

                if (heroMp + amount > 200)
                {
                    amount = 200 - heroMp;
                }

                heroMp += amount;
                heroes[heroName][1] = heroMp;
                Console.WriteLine($"{heroName} recharged for {amount} MP!");
            }
        }

        static void Heal(Dictionary<string, List<int>> heroes, string heroName, int amount)
        {
            if (heroes.ContainsKey(heroName))
            {
                int heroHp = heroes[heroName][0];

                if (heroHp + amount > 100)
                {
                    amount = 100 - heroHp;
                }

                heroHp += amount;
                heroes[heroName][0] = heroHp;
                Console.WriteLine($"{heroName} healed for {amount} HP!");
            }
        }
    }
}