// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace AbsoluteDifference
{
    using System;
    using System.Globalization;

    /// <summary>
    /// The main class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Please provide a value for n: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(FindDifference(n));

            Console.WriteLine("Program has finished execution, please press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Method that will calculate the absolute difference btween n and 51. 
        /// If n is greater than 51 return triple the absolute difference
        /// </summary>
        /// <param name="n">Value passed through the console</param>
        /// <returns>Absolute difference</returns>
        private static int FindDifference(int n)
        {
            const int x = 51;

            if (n > x)
            {
                return (n - x) * 3;
            }
            else
            {
                return x - n;
            }
        }
    }
}