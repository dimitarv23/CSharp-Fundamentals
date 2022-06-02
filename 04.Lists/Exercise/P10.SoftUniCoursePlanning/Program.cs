using System;
using System.Collections.Generic;
using System.Linq;

namespace P10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lections = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<bool> haveLectionsExercise = new List<bool>();
            //By default all the lections don't have exercises
            for (int i = 0; i < lections.Count; i++)
            {
                haveLectionsExercise.Add(false);
            }

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] cmdArgs = input.Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = cmdArgs[0];
                string title = cmdArgs[1];
                bool isTitleContained = lections.Contains(title);

                if (action == "Add" && !isTitleContained)
                {
                    //If the lesson title doesn't exist in the course
                    lections.Add(title);
                    haveLectionsExercise.Add(false);
                }
                else if (action == "Insert" && !isTitleContained)
                {
                    //If the lesson title doesn't exist in the course
                    int index = int.Parse(cmdArgs[2]);
                    lections.Insert(index, title);
                    haveLectionsExercise.Insert(index, false);
                }
                else if (action == "Remove" && isTitleContained)
                {
                    int removeIndex = lections.FindIndex(x => x == title);
                    lections.Remove(title);

                    if (haveLectionsExercise[removeIndex])
                    {
                        haveLectionsExercise[removeIndex] = false;
                    }
                }
                else if (action == "Swap")
                {
                    string secondTitle = cmdArgs[2];
                    bool isSecondTitleContained = lections.Contains(secondTitle);

                    if (isTitleContained && isSecondTitleContained)
                    {
                        SwapLections(lections, haveLectionsExercise, title, secondTitle);
                    }
                }
                else if (action == "Exercise")
                {
                    if (isTitleContained)
                    {
                        int indexOfTitle = lections.FindIndex(x => x == title);
                        haveLectionsExercise[indexOfTitle] = true;
                    }
                    else
                    {
                        lections.Add(title);
                        haveLectionsExercise.Add(true);
                    }
                }

                input = Console.ReadLine();
            }

            int counter = 1;
            //Print the course lections
            for (int i = 0; i < lections.Count; i++)
            {
                Console.WriteLine($"{counter}.{lections[i]}");
                counter++;

                if (haveLectionsExercise[i])
                {
                    //If the index of the lection in the current list returns true, then the lection should have an exercise after it and we should print it
                    Console.WriteLine($"{counter}.{lections[i]}-Exercise");
                    counter++;
                }
            }
        }

        static void SwapLections(List<string> lections, List<bool> exerciseOnLections, string title1, string title2)
        {
            int firstTitleIndex = lections.FindIndex(x => x == title1);
            int secondTitleIndex = lections.FindIndex(x => x == title2);

            string tempTitle = title1;
            lections[firstTitleIndex] = title2;
            lections[secondTitleIndex] = tempTitle;

            bool tempExercise = exerciseOnLections[firstTitleIndex];
            exerciseOnLections[firstTitleIndex] = exerciseOnLections[secondTitleIndex];
            exerciseOnLections[secondTitleIndex] = tempExercise;
        }
    }
}
