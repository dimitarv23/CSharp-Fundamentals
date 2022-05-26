using System;
using System.Linq;

namespace P10_LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());

            int[] ladyBugIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] fieldMap = new int[sizeOfField]; //Shows on which indexes on the field are the ladybugs
            for (int i = 0; i < ladyBugIndexes.Length; i++) //Adds the ladybugs on their positions, given from the console
            {
                if (ladyBugIndexes[i] >= 0 && ladyBugIndexes[i] < fieldMap.Length)
                {
                    fieldMap[ladyBugIndexes[i]] = 1; //If there's a ladybug => fieldmap[index] = 1, otherwise => 0
                }
            }

            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "end")
            {
                int ladyBugIndex = int.Parse(commands[0]);
                string direction = commands[1];
                int flyLength = int.Parse(commands[2]);

                if (ladyBugIndex >= 0 && ladyBugIndex < fieldMap.Length) //Checks if the given index is within the indexes of the array
                {
                    if (fieldMap[ladyBugIndex] != 0) //Checks if there are any ladybugs on this index, if there ain't any -> does nothing
                    {
                        fieldMap[ladyBugIndex] = 0;

                        if (direction == "right")
                        {
                            for (int i = ladyBugIndex + flyLength; i < fieldMap.Length && i >= 0; i += flyLength)
                            {
                                if (fieldMap[i] == 0)
                                {
                                    fieldMap[i] = 1;
                                    break;
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            for (int i = ladyBugIndex - flyLength; i >= 0 && i < fieldMap.Length; i -= flyLength)
                            {
                                if (fieldMap[i] == 0)
                                {
                                    fieldMap[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }
                commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(String.Join(' ', fieldMap));
        }
    }
}
