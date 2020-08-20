// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace NumberGuessingGame
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            while (true)
            {
                int randomNumber = NewNumber(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 and 100 (0 will quit)");
                    int guessInt = int.Parse(Console.ReadLine());
                    if (guessInt == 0)
                    {
                        return;
                    }
                    else if (guessInt < randomNumber)
                    {
                        Console.WriteLine("Low, try again!");
                        ++count;
                        continue;
                    }
                    else if (guessInt > randomNumber)
                    {
                        Console.WriteLine("High, try again!");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Bingo! The number I thought about is {0}", randomNumber);
                        Console.WriteLine("It took you {0} {1}. \n", count, count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// This method generates a new number.
        /// </summary>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A number to be used.</returns>
        public static int NewNumber(int min, int max)
        {
            Random randomGen = new Random();
            return randomGen.Next(min, max);
        }
    }
}