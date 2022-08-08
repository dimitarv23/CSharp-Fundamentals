using System;
using System.Linq;

namespace P01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] cmdArgs = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newStop = cmdArgs[2];

                    if (IsIndexValid(index, stops))
                    {
                        stops = stops.Insert(index, newStop);
                    }
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (IsIndexValid(startIndex, stops) && IsIndexValid(endIndex, stops))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (action == "Switch")
                {
                    string oldStop = cmdArgs[1];
                    string newStop = cmdArgs[2];

                    if (stops.Contains(oldStop))
                    {
                        stops = stops.Replace(oldStop, newStop);
                    }
                }

                Console.WriteLine(stops);
                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        static bool IsIndexValid(int index, string str)
        {
            if (index >= 0 && index < str.Length)
            {
                return true;
            }

            return false;
        }
    }
}
