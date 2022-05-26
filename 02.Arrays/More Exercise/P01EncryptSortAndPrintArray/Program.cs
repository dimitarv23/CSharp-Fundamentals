using System;

namespace P01EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());

            int[] encryptedInformation = new int[arrayLength];
            string vowels = "AaEeIiOoUu";

            for (int i = 0; i < arrayLength; i++)
            {
                string currentInfo = Console.ReadLine();

                int vowelsSum = 0;
                int consonantsSum = 0;

                foreach (char info in currentInfo)
                {
                    if (vowels.Contains(info))
                    {
                        vowelsSum += info * currentInfo.Length;
                    }
                    else
                    {
                        consonantsSum += info / currentInfo.Length;
                    }
                }
                encryptedInformation[i] = vowelsSum + consonantsSum;
            }
            Array.Sort(encryptedInformation);

            for (int i = 0; i < encryptedInformation.Length; i++)
            {
                Console.WriteLine(encryptedInformation[i]);
            }
        }
    }
}
