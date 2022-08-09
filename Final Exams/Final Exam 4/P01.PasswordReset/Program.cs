using System;
using System.Text;

namespace P01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "TakeOdd")
                {
                    password = TakeOdd(password);
                    Console.WriteLine(password);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (action == "Substitute")
                {
                    string oldText = cmdArgs[1];
                    string newText = cmdArgs[2];

                    if (password.Contains(oldText))
                    {
                        password = password.Replace(oldText, newText);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }

        static string TakeOdd(string pass)
        {
            StringBuilder rawPassword = new StringBuilder();

            for (int i = 1; i < pass.Length; i += 2)
            {
                rawPassword.Append(pass[i]);
            }

            return rawPassword.ToString();
        }
    }
}
