using System;

namespace P04PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool firstCheck = CheckCharsCount(password);
            bool secondCheck = CheckCharsType(password);
            bool thirdCheck = CheckDigitsCount(password);

            if (firstCheck && secondCheck && thirdCheck)
            {
                Console.WriteLine("Password is valid", Console.ForegroundColor = ConsoleColor.Green);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static bool CheckCharsCount(string pass)
        {
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                return true;
            }
            Console.WriteLine("Password must be between 6 and 10 characters", Console.ForegroundColor = ConsoleColor.Red);
            return false;
        }
        static bool CheckCharsType(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                bool condition = (pass[i] < '0' || pass[i] > '9') && (pass[i] < 'a' || pass[i] > 'z') && (pass[i] < 'A' || pass[i] > 'Z');

                if (condition)
                {
                    Console.WriteLine("Password must consist only of letters and digits", Console.ForegroundColor = ConsoleColor.Red);
                    return false;
                }
            }
            return true;
        }
        static bool CheckDigitsCount(string pass)
        {
            int digitsCount = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= '0' && pass[i] <= '9')
                {
                    digitsCount++;
                }
            }
            if (digitsCount >= 2)
            {
                return true;
            }
            Console.WriteLine("Password must have at least 2 digits", Console.ForegroundColor = ConsoleColor.Red);
            return false;
        }
    }
}
