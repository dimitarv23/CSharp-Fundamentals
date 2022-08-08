using System;
using System.Linq;
using System.Text;

namespace P01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] cmdArgs = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);

                    message = message.Insert(index, " ");
                }
                else if (action == "Reverse")
                {
                    string substring = cmdArgs[1];

                    if (message.Contains(substring))
                    {
                        int indexOfSubstring = message.IndexOf(substring);
                        message = message.Remove(indexOfSubstring, substring.Length);
                        substring = Reverse(substring);
                        message = message.Insert(message.Length, substring);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    message = message.Replace(substring, replacement);
                }

                Console.WriteLine(message);
                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }

        static string Reverse(string str)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }

            return reversed.ToString();
        }
    }
}
