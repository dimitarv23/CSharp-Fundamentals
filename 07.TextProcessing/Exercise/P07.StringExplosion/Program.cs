using System;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool flag = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int strength = int.Parse(input[i + 1].ToString());

                    if (strength == 1)
                    {
                        input = input.Remove(i + 1, 1);
                    }
                    else
                    {
                        while (strength != 0)
                        {
                            if (i + 1 >= input.Length)
                            {
                                flag = true;
                                break;
                            }

                            if (input[i + 1] == '>')
                            {
                                int newStrength = int.Parse(input[i + 2].ToString());
                                strength += newStrength;
                                i++;
                            }

                            input = input.Remove(i + 1, 1);
                            strength--;
                        }

                        if (flag)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
