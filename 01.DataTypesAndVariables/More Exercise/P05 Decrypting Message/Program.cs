using System;
using System.Text;

namespace P05_Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            StringBuilder decryptedMessage = new StringBuilder();

            for (byte i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                char decryptedLetter = (char)(letter + key);
                decryptedMessage.Append(decryptedLetter);
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
