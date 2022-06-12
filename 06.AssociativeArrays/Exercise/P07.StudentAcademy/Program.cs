using System;
using System.Linq;
using System.Collections.Generic;

namespace P07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students.Add(studentName, new List<double>() { studentGrade });
                }
            }

            foreach (var student in students)
            {
                double averageGrade = student.Value.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
