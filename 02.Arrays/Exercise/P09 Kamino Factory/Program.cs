using System;

namespace P09_Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequences = int.Parse(Console.ReadLine());

            string[] sequence = new string[lengthOfSequences];
            string[] bestSequence = new string[lengthOfSequences];

            int sampleNumber = 0;
            int longestOnesStreak = 0;
            int leftmostStartOfStreakIndex = lengthOfSequences;
            int bestDNASampleNumber = 0;
            int mostOnesInASequence = 0;
            int sum = 0;

            while (sequence[0] != "Clone them")
            {
                sequence = Console.ReadLine()
                    .Split('!', StringSplitOptions.RemoveEmptyEntries);

                sampleNumber++;

                int consecutiveNumberOfOnes = 0;
                int totalNumberOfOnes = 0;

                int currentOnesStreak = 0;
                int startOfStreakIndex = 0;

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == "1")
                    {
                        consecutiveNumberOfOnes++;
                        totalNumberOfOnes++;
                    }
                    else
                    {
                        consecutiveNumberOfOnes = 0;
                    }

                    if (consecutiveNumberOfOnes > currentOnesStreak)
                    {
                        currentOnesStreak = consecutiveNumberOfOnes;
                        startOfStreakIndex = i;
                    }
                }

                if (currentOnesStreak > longestOnesStreak)
                {
                    leftmostStartOfStreakIndex = startOfStreakIndex;
                    mostOnesInASequence = totalNumberOfOnes;

                    longestOnesStreak = currentOnesStreak;
                    bestDNASampleNumber = sampleNumber;
                    bestSequence = sequence;
                    sum = totalNumberOfOnes;
                }
                else if (currentOnesStreak == longestOnesStreak)
                {
                    if (startOfStreakIndex < leftmostStartOfStreakIndex)
                    {
                        leftmostStartOfStreakIndex = startOfStreakIndex;
                        mostOnesInASequence = totalNumberOfOnes;

                        longestOnesStreak = currentOnesStreak;
                        bestDNASampleNumber = sampleNumber;
                        bestSequence = sequence;
                        sum = totalNumberOfOnes;
                    }
                    else if (startOfStreakIndex == leftmostStartOfStreakIndex)
                    {
                        if (totalNumberOfOnes > mostOnesInASequence)
                        {
                            longestOnesStreak = currentOnesStreak;
                            bestDNASampleNumber = sampleNumber;
                            bestSequence = sequence;
                            sum = totalNumberOfOnes;
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestDNASampleNumber} with sum: {sum}.");
            Console.WriteLine(String.Join(' ', bestSequence));
        }
    }
}
