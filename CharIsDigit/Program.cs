// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace CharIsDigit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an input to find out if it is a number: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            bool finalResult = IsDigit(symbol);

            Console.WriteLine($"Is {symbol} a digit? {finalResult}");

            Console.ReadKey();
        }

        /// <summary>
        /// Method that would return a value making the determination whether or not
        /// the string that the user provides is a digit or not
        /// </summary>
        /// <param name="symbol">The string put in by the user</param>
        /// <returns>A true or false value</returns>
        static bool IsDigit(char symbol)
        {
            bool valid = true;
            if (char.IsNumber(symbol))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }
    }
}