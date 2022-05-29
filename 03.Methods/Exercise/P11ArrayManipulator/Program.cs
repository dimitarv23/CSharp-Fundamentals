using System;
using System.Linq;

namespace P11ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            CheckCommand(command, numbers);

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }

        static void CheckCommand(string command, int[] numbers)
        {
            while (command != "end")
            {
                string[] splittedCommands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (splittedCommands[0] == "exchange")
                {
                    Exchange(numbers, int.Parse(splittedCommands[1]));
                }
                else if (splittedCommands[0] == "max")
                {
                    if (splittedCommands[1] == "even")
                    {
                        Console.WriteLine(GetMaxEven(numbers));
                    }
                    else if (splittedCommands[1] == "odd")
                    {
                        Console.WriteLine(GetMaxOdd(numbers));
                    }
                }
                else if (splittedCommands[0] == "min")
                {
                    if (splittedCommands[1] == "even")
                    {
                        Console.WriteLine(GetMinEven(numbers));
                    }
                    else if (splittedCommands[1] == "odd")
                    {
                        Console.WriteLine(GetMinOdd(numbers));
                    }
                }
                else if (splittedCommands[0] == "first")
                {
                    int count = int.Parse(splittedCommands[1]);

                    if (splittedCommands[2] == "even")
                    {
                        PrintFirstEven(numbers, count);
                    }
                    else if (splittedCommands[2] == "odd")
                    {
                        PrintFirstOdd(numbers, count);
                    }
                }
                else if (splittedCommands[0] == "last")
                {
                    int count = int.Parse(splittedCommands[1]);

                    if (splittedCommands[2] == "even")
                    {
                        PrintLastEven(numbers, count);
                    }
                    else if (splittedCommands[2] == "odd")
                    {
                        PrintLastOdd(numbers, count);
                    }
                }
                command = Console.ReadLine();
            }
        }

        static void Exchange(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            int[] leftSubArray = arr.Take(index + 1).ToArray(); //Split the array after the given index in 2 sub-arrays
            int[] rightSubArray = arr.Skip(index + 1).ToArray();

            for (int i = 0; i < rightSubArray.Length; i++)
            {
                arr[i] = rightSubArray[i];
            }
            for (int i = rightSubArray.Length; i < rightSubArray.Length + leftSubArray.Length; i++)
            {
                arr[i] = leftSubArray[i - rightSubArray.Length];
            }
        }

        static string GetMaxEven(int[] arr)
        {
            int max = int.MinValue;
            string maxIndex = "No matches";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] >= max)
                {
                    max = arr[i];
                    maxIndex = i.ToString();
                }
            }
            return maxIndex;
        }
        static string GetMaxOdd(int[] arr)
        {
            int max = int.MinValue;
            string maxIndex = "No matches";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] >= max)
                {
                    max = arr[i];
                    maxIndex = i.ToString();
                }
            }
            return maxIndex;
        }

        static string GetMinEven(int[] arr)
        {
            int min = int.MaxValue;
            string minIndex = "No matches";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] <= min)
                {
                    min = arr[i];
                    minIndex = i.ToString();
                }
            }
            return minIndex;
        }
        static string GetMinOdd(int[] arr)
        {
            int min = int.MaxValue;
            string minIndex = "No matches";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] <= min)
                {
                    min = arr[i];
                    minIndex = i.ToString();
                }
            }
            return minIndex;
        }

        static void PrintFirstEven(int[] arr, int count)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int[] firstEvenElements = new int[count];
            int counterFirstEven = 0;
            int counterEvenNumbers = 0;

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    firstEvenElements[counterFirstEven] = item;
                    counterFirstEven++;
                    counterEvenNumbers++;

                    if (counterFirstEven >= count)
                    {
                        break;
                    }
                }
            }

            if (counterEvenNumbers < count)
            {
                Console.WriteLine($"[{String.Join(", ", firstEvenElements.Where(x => x != 0))}]");
            }
            else
            {
                Console.WriteLine($"[{String.Join(", ", firstEvenElements)}]");
            }
        }
        static void PrintFirstOdd(int[] arr, int count)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int[] firstOddElements = new int[count];
            int counterFirstOdd = 0;
            int counterOddNumbers = 0;

            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    firstOddElements[counterFirstOdd] = item;
                    counterFirstOdd++;
                    counterOddNumbers++;

                    if (counterFirstOdd >= count)
                    {
                        break;
                    }
                }
            }

            if (counterOddNumbers < count)
            {
                Console.WriteLine($"[{String.Join(", ", firstOddElements.Where(x => x != 0))}]");
            }
            else
            {
                Console.WriteLine($"[{String.Join(", ", firstOddElements)}]");
            }
        }

        static void PrintLastEven(int[] arr, int count)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] lastEvenElements = new int[count];
            int counterLastEven = 0;
            int counterEvenNumbers = 0;

            Array.Reverse(arr); //Reverse the array so we can get the last N elements as first

            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    lastEvenElements[counterLastEven] = item;
                    counterLastEven++;
                    counterEvenNumbers++;

                    if (counterLastEven >= count)
                    {
                        break;
                    }
                }
            }
            Array.Reverse(arr); //Reverse the array as it was normally
            Array.Reverse(lastEvenElements);

            if (counterEvenNumbers < count)
            {
                Console.WriteLine($"[{String.Join(", ", lastEvenElements.Where(x => x != 0))}]");
            }
            else
            {
                Console.WriteLine($"[{String.Join(", ", lastEvenElements)}]");
            }
        }
        static void PrintLastOdd(int[] arr, int count)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] lastOddElements = new int[count];
            int counterLastOdd = 0;
            int counterOddNumbers = 0;

            Array.Reverse(arr); //Reverse the array so we can get the last N elements as first

            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    lastOddElements[counterLastOdd] = item;
                    counterLastOdd++;
                    counterOddNumbers++;

                    if (counterLastOdd >= count)
                    {
                        break;
                    }
                }
            }
            Array.Reverse(arr); //Reverse the array as it was normally
            Array.Reverse(lastOddElements);

            if (counterOddNumbers < count)
            {
                Console.WriteLine($"[{String.Join(", ", lastOddElements.Where(x => x != 0))}]");
            }
            else
            {
                Console.WriteLine($"[{String.Join(", ", lastOddElements)}]");
            }
        }
    }
}
