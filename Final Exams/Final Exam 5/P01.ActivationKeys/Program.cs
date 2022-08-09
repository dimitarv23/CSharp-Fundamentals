using System;

namespace P01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Generate")
            {
                string[] cmdArgs = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Contains")
                {
                    string substring = cmdArgs[1];

                    Contains(activationKey, substring);
                }
                else if (action == "Flip")
                {
                    string direction = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);

                    activationKey = Flip(activationKey, direction, startIndex, endIndex);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    activationKey = Slice(activationKey, startIndex, endIndex);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        static void Contains(string rawActivationKey, string substring)
        {
            if (rawActivationKey.Contains(substring))
            {
                Console.WriteLine($"{rawActivationKey} contains {substring}");
                return;
            }

            Console.WriteLine("Substring not found!");
        }

        static string Flip(string rawActivationKey, string direction, int startIndex, int endIndex)
        {
            string textToFlip = rawActivationKey.Substring(startIndex, endIndex - startIndex);

            if (direction == "Upper")
            {
                rawActivationKey = rawActivationKey.Replace(textToFlip, textToFlip.ToUpper());
            }
            else if (direction == "Lower")
            {
                rawActivationKey = rawActivationKey.Replace(textToFlip, textToFlip.ToLower());
            }

            Console.WriteLine(rawActivationKey);
            return rawActivationKey;
        }

        static string Slice(string rawActivationKey, int startIndex, int endIndex)
        {
            rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);

            Console.WriteLine(rawActivationKey);
            return rawActivationKey;
        }
    }
}
