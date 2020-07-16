// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace FindTheHiddenNumber
{
    using System;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main driver method.
        /// </summary>
        /// <param name="args">Project specific command line arguments.</param>
        public static void Main(string[] args)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int n = a.Length;

            int hiddenNumber = FindHiddenNumber(a, n);

            Console.WriteLine($"The hidden number in the array: {hiddenNumber}");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This method finds the hidden number.
        /// </summary>
        /// <param name="a">An array of integers.</param>
        /// <param name="n">An integer value to find.</param>
        /// <returns>An integer value when the value is being found.</returns>
        public static int FindHiddenNumber(int[] a, int n)
        {
            long sum = 0; 
            for(int i = 0; i < n; i++)
            {
                sum += a[i];
            }

            // Dividing the sum by size of n
            long x = sum / n;

            // Print x, if found
            if (x * n == sum)
            {
                return (int)x; 
            }
            else
            {
                return -1; 
            }
        }
    }
}