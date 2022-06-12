using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.DragonArmy
{
    class GroupedDragon
    {
        public string Type { get; set; }
        public List<Dragon> Dragons { get; set; }
    }

    class Dragon
    {
        public Dragon(string name, string type, int damage, int health, int armor)
        {
            this.Name = name;
            this.Type = type;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dragon> dragons = new List<Dragon>();
            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                int value = 0;
                string[] dragonInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = dragonInfo[0];
                string name = dragonInfo[1];
                int damage = int.TryParse(dragonInfo[2], out value) ? value : 45;
                int health = int.TryParse(dragonInfo[3], out value) ? value : 250;
                int armor = int.TryParse(dragonInfo[4], out value) ? value : 10;

                if (dragons.Any(d => d.Type == type && d.Name == name))
                {
                    //The dragon is duplicated => overwrite the old dragon with the newly given stats
                    int indexOfDragon = dragons.FindIndex(d => d.Type == type && d.Name == name);
                    dragons[indexOfDragon].Damage = damage;
                    dragons[indexOfDragon].Health = health;
                    dragons[indexOfDragon].Armor = armor;
                    continue;
                }
                //Add a new dragon with key (the type) and value (a dictionary with key (name) and value (List of stats))
                Dragon newDragon = new Dragon(name, type, damage, health, armor);
                dragons.Add(newDragon);
            }

            var groupedDragons = dragons.GroupBy(
                            d => d.Type,
                            d => d,
                            (key, d) => new GroupedDragon()
                            {
                                Type = key,
                                Dragons = d.ToList()
                            });

            foreach (GroupedDragon dragon in groupedDragons)
            {
                int dragonCount = dragon.Dragons.Count;
                double damage = (double)dragon.Dragons.Sum(d => d.Damage) / dragonCount;
                double health = (double)dragon.Dragons.Sum(d => d.Health) / dragonCount;
                double armour = (double)dragon.Dragons.Sum(d => d.Armor) / dragonCount;

                Console.WriteLine($"{dragon.Type}::({damage:F2}/{health:F2}/{armour:F2})");

                foreach (Dragon dragon2 in dragon.Dragons.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"-{dragon2.Name} -> damage: {dragon2.Damage}, health: {dragon2.Health}, armor: {dragon2.Armor}");
                }
            }
        }
    }
}