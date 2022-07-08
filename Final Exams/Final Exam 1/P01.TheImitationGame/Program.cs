using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] cmdArgs = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Move")
                {
                    int numberOfLetters = int.Parse(cmdArgs[1]);
                    MoveLetters(ref message, numberOfLetters);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];
                    message = message.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string oldString = cmdArgs[1];
                    string newString = cmdArgs[2];
                    message = message.Replace(oldString, newString);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }

        static void MoveLetters(ref string message, int numberOfLetters)
        {
            string lettersToMove = message.Substring(0, numberOfLetters);
            message = message.Insert(message.Length, lettersToMove);
            message = message.Remove(0, numberOfLetters);
        }
    }
}
