using System;
using System.Collections.Generic;
using System.Text;

namespace P04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCodes = new Dictionary<string, char>()
            {
                [".-"] = 'A',
                ["-..."] = 'B',
                ["-.-."] = 'C',
                ["-.."] = 'D',
                ["."] = 'E',
                ["..-."] = 'F',
                ["--."] = 'G',
                ["...."] = 'H',
                [".."] = 'I',
                [".---"] = 'J',
                ["-.-"] = 'K',
                [".-.."] = 'L',
                ["--"] = 'M',
                ["-."] = 'N',
                ["---"] = 'O',
                [".--."] = 'P',
                ["--.-"] = 'Q',
                [".-."] = 'R',
                ["..."] = 'S',
                ["-"] = 'T',
                ["..-"] = 'U',
                ["...-"] = 'V',
                [".--"] = 'W',
                ["-..-"] = 'X',
                ["-.--"] = 'Y',
                ["--.."] = 'Z'
            };

            string[] morseLetters = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder translation = new StringBuilder();

            foreach (string letter in morseLetters)
            {
                if (letter == "|")
                {
                    translation.Append(' ');
                    continue;
                }
                translation.Append(morseCodes[letter]);
            }

            Console.WriteLine(translation);
        }
    }
}
