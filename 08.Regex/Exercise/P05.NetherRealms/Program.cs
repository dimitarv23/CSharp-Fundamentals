using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> demonsInfo = new Dictionary<string, List<double>>();
            string[] demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string healthPattern = @"[^0-9+\-*\/\.]";
            string damagePattern = @"[+-]?(?<number>[0-9]+(\.[0-9]+)?)";

            foreach (var demon in demons)
            {
                MatchCollection healthMatches = Regex.Matches(demon, healthPattern);
                int health = 0;

                foreach (Match match in healthMatches)
                {
                    string currMatchStr = match.ToString();
                    char[] currMatch = currMatchStr.ToCharArray();

                    foreach (var ch in currMatch)
                    {
                        health += ch;
                    }
                }

                MatchCollection damageMatches = Regex.Matches(demon, damagePattern);
                double damage = 0;

                foreach (Match num in damageMatches)
                {
                    double currDamage = double.Parse(num.ToString());
                    damage += currDamage;
                }

                foreach (char sym in demon)
                {
                    if (sym == '*')
                    {
                        damage *= 2;
                    }
                    else if (sym == '/')
                    {
                        damage /= 2;
                    }
                }

                demonsInfo.Add(demon, new List<double>
                {
                    health,
                    damage
                });
            }

            foreach (var demon in demonsInfo.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}
