using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.Students
{
    class Student
    {
        public Student(string fN, string lN, double gr)
        {
            this.FirstName = fN;
            this.LastName = lN;
            this.Grade = gr;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] stdInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student currStudent = new Student(stdInfo[0], stdInfo[1], double.Parse(stdInfo[2]));
                students.Add(currStudent);
            }

            List<Student> sortedStudents = students.OrderBy(x => x.Grade).ToList();
            sortedStudents.Reverse();

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
