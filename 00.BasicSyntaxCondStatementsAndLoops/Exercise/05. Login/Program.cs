using System;
using System.Text;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            StringBuilder pass = new StringBuilder();

            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass.Append(username[i]);
            }
            string password = pass.ToString();

            string currentGuess = Console.ReadLine();
            int counterIncorrect = 0;

            while (currentGuess != password)
            {
                counterIncorrect++;
                if (counterIncorrect == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");

                currentGuess = Console.ReadLine();
            }
            if (currentGuess == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
