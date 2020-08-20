// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace LinqBasicStructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This is the main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The driver method/main entry point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Provide a list of space separated integers: ");
            string[] temp = Console.ReadLine().Split(' ');
            int[] inputArray = Array.ConvertAll(temp, int.Parse);

            Console.WriteLine("Provide a value for which the remainder would equal 0");
            int inputInt = int.Parse(Console.ReadLine());

            var finalQuery = FindResults(inputArray, inputInt);

            Console.WriteLine("The results are as follows: ");
            foreach (int finalNum in finalQuery)
            {
                Console.Write("{0} ", finalNum); 
            }

            // Signaling that the program is completed.
            Console.WriteLine("Program is now finished, press any key to exit"); 
            Console.ReadKey(); 
        }

        /// <summary>
        /// Having the ability to return a list using LINQ code.
        /// </summary>
        /// <param name="inputArray">The array of integers that are passed in.</param>
        /// <param name="x">What is the number to divide by to see if the remainder would be 0.</param>
        /// <returns>A list of the quotients.</returns>
        private static List<int> FindResults(int[] inputArray, int x)
        {
            var outputQuery = from resultNumber in inputArray
                              where (resultNumber % x) == 0
                              select resultNumber;

            return outputQuery.ToList(); 
        }
    }
}