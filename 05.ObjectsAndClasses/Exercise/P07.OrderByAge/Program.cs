using System;
using System.Linq;
using System.Collections.Generic;

namespace P07.OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] personInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string personName = personInfo[0];
                string personId = personInfo[1];
                int personAge = int.Parse(personInfo[2]);

                if (people.Exists(person => person.Id == personId))
                {
                    int indexOfDuplicatedId = people.FindIndex(person => person.Id == personId);

                    people[indexOfDuplicatedId].Name = personName;
                    people[indexOfDuplicatedId].Age = personAge;
                }
                else
                {
                    Person newPerson = new Person(personName, personId, personAge);
                    people.Add(newPerson);
                }

                input = Console.ReadLine();
            }

            List<Person> sortedPeople = people.OrderBy(x => x.Age).ToList();

            foreach (Person person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
