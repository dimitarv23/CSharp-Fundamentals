using System;
using System.Text;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int messageLength = int.Parse(Console.ReadLine());
            StringBuilder finalMessage = new StringBuilder();

            for (int i = 1; i <= messageLength; i++)
            {
                string input = Console.ReadLine();

                int mainValue = int.Parse(input[0].ToString());

                if (mainValue == 0)
                {
                    finalMessage.Append(" ");
                    continue;
                }
                int currentDigitASCII = 91 + (mainValue * 3);

                if (input.Length == 2)
                {
                    currentDigitASCII++;
                }
                else if (input.Length == 3)
                {
                    currentDigitASCII += 2;
                }
                else if (input.Length == 4)
                {
                    currentDigitASCII += 3;
                }

                if (mainValue > 7)
                {
                    currentDigitASCII++;
                }
                finalMessage.Append((char)currentDigitASCII);
            }
            Console.WriteLine(finalMessage);
        }
    }
}
