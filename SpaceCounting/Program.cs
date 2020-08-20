// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace SpaceCounting
{
    using System;

    /// <summary>
    /// This is the main class of this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method/main entry point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            string inputStr;
            Console.Write("\n\n Function to count the number of spaces in a string: \n");
            Console.Write("---------------------------------------------------------\n");
            Console.Write("Please provide a string: ");
            inputStr = Console.ReadLine();

            Console.WriteLine("\"" + inputStr + "\"" + " contains {0} spaces", CountingSpaces(inputStr));

            Console.WriteLine("Program execution has completed, you may now press any key to exit.");
            Console.ReadKey();
        }

        private static int CountingSpaces(string inputString)
        {
            int spcCntr = 0;

            string input;
            for (int i = 0; i < inputString.Length; i++)
            {
                input = inputString.Substring(i, 1);
                if (input == " ")
                {
                    spcCntr++; 
                }
            }

            return spcCntr;
        }
    }
}