using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace P01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<char> encryptedMessage = Console.ReadLine()
                .ToCharArray()
                .ToList();

            StringBuilder decryptedMessage = new StringBuilder();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int sumDigits = 0;

                //Get the sum of the digits
                while (currentNumber != 0)
                {
                    sumDigits += currentNumber % 10;
                    currentNumber /= 10;
                }

                int indexToGet = sumDigits % encryptedMessage.Count;
                decryptedMessage.Append(encryptedMessage[indexToGet]);
                encryptedMessage.RemoveAt(indexToGet);
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
