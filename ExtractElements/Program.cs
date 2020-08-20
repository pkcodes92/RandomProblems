// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ExtractElements
{
    using System;
    using System.Linq;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main method, entry point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            // Standard test case
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 3;

            int[] outputArray = ExtractEachKth(inputArray, k);
            foreach (int item in outputArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// This method will extract subarrays at each kth interval.
        /// </summary>
        /// <param name="inputArray">The input array of integers.</param>
        /// <param name="k">The kth interval to extract.</param>
        /// <returns>An array of integers.</returns>
        public static int[] ExtractEachKth(int[] inputArray, int k)
        {
            return inputArray.Where((x, y) => y % k != k - 1).ToArray();
        }
    }
}