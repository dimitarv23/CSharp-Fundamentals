using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OldestFamilyMember
{
    class Family
    {
        public Family()
        {
            FamilyMembers = new List<Person>();
        }

        public List<Person> FamilyMembers = new List<Person>();

        public void AddMember(Person member)
        {
            FamilyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            int ageOfOldestMember = FamilyMembers.Max(x => x.Age);
            Person oldestMember = FamilyMembers.Find(x => x.Age == ageOfOldestMember);
            return oldestMember;
        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person newPerson = new Person(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(newPerson);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
