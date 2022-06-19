using System;

namespace P01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                if (IsUsernameValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
        static bool IsUsernameValid(string username)
        {
            bool firstCondition = username.Length >= 3 && username.Length <= 16;
            bool secondCondition = HasOnlyLettersDigitsOrHyphens(username);

            if (firstCondition && secondCondition)
            {
                return true;
            }
            return false;
        }
        static bool HasOnlyLettersDigitsOrHyphens(string username)
        {
            foreach (char ch in username)
            {
                if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
