// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace IsUniqueCharacters
{
    using System;

    /// <summary>
    /// This is the main class for the project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Please provide a string to analyze: ");

            string inputString = Console.ReadLine();

            var isUnique = ContainsUniqueChars(inputString);

            Console.WriteLine($"Does the provided string => {inputString} contain unique characters? {isUnique}");

            Console.WriteLine("Program execution has finished, you may now press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Looks at the characters in the provided string to see if the entire string
        /// contains unique characters
        /// </summary>
        /// <param name="inputString">The string that was provided by the user</param>
        /// <returns>A boolean value to determine if the string contains unique characters or not</returns>
        private static bool ContainsUniqueChars(string inputString)
        {
            if (inputString.Length > 128)
            {
                return false;
            }

            // Having the charSet array to be 128 for ASCII encoding
            bool[] charSet = new bool[128];

            for (int i = 0; i < inputString.Length; i++)
            {
                int val = inputString[i];
                if (charSet[val])
                {
                    return false;
                }

                charSet[val] = true;
            }

            return true;
        }
    }
}