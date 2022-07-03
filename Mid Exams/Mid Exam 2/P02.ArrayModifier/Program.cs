using System;
using System.Linq;

namespace P02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "swap")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);
                    Swap(numbers, index1, index2);
                }
                else if (action == "multiply")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);
                    Multiply(numbers, index1, index2);
                }
                else if (action == "decrease")
                {
                    Decrease(numbers);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        //Swaps two elements at given indexes in an array
        static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
        //Multiplies two element at given indexes and saves the multiplication to the first given index of the array
        static void Multiply(int[] arr, int index1, int index2)
        {
            int multiplication = arr[index1] * arr[index2];
            arr[index1] = multiplication;
        }
        //Decreases all elements in an array with 1
        static void Decrease(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }
    }
}
