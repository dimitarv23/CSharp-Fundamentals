using System;
using System.Collections.Generic;

namespace P04.Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] studentInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string hometown = studentInfo[3];

                Student std = new Student(firstName, lastName, age, hometown);
                students.Add(std);

                input = Console.ReadLine();
            }

            string givenCity = Console.ReadLine();

            List<Student> filteredStudents = students.FindAll(x => x.Hometown == givenCity);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

            //foreach (Student student in students)
            //{
            //    if (student.Hometown == givenCity)
            //    {
            //        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //    }
            //}
        }
    }
}
