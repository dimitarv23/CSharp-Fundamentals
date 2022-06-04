using System;
using System.Collections.Generic;

namespace P05.Students2._0
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

                bool isNameRepeated = !OverwriteIfNecessary(students, firstName, lastName, age, hometown);
                //If the first and the last name are repeated, overwrite the student's information and return true, if the method returns false, create a new object of type Student and add it to the list
                if (isNameRepeated)
                {
                    Student std = new Student(firstName, lastName, age, hometown);
                    students.Add(std);
                }

                input = Console.ReadLine();
            }

            string givenCity = Console.ReadLine();
            List<Student> filteredStudents = students.FindAll(x => x.Hometown == givenCity);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        //Returns true if a student has been overwritten, otherwise => false
        static bool OverwriteIfNecessary(List<Student> students,
            string firstName, string lastName, int age, string hometown)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].FirstName == firstName && students[i].LastName == lastName)
                {
                    students[i].Age = age;
                    students[i].Hometown = hometown;
                    return true;
                }
            }
            return false;
        }
    }
}
