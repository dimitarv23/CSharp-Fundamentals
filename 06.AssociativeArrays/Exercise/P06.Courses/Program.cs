using System;
using System.Collections.Generic;

namespace P06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArgs[0];
                string username = cmdArgs[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(username);
                }
                else
                {
                    courses.Add(courseName, new List<string>() { username });
                }

                input = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var user in course.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
