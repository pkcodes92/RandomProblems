// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StringCompression
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main driver method.
        /// </summary>
        /// <param name="args">Project specific command line arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to compress: ");
            string inputString = Console.ReadLine();

            string outputString = Compress(inputString);

            Console.WriteLine($"{inputString} compressed is: {outputString}");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }

        private static string Compress(string inputString)
        {
            string compressedString = "";
            int countConsecutive = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                countConsecutive++;

                /* If the next character is different than current, append this char to result. */
                if (i + 1 >= inputString.Length || inputString[i] != inputString[i + 1])
                {
                    compressedString += "" + inputString[i] + countConsecutive;
                    countConsecutive = 0;
                }
            }

            return compressedString.Length < inputString.Length ? inputString : compressedString;
        }
    }
}