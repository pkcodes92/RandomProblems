// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace SumOfSubarrays
{
    using System;

    /// <summary>
    /// This is the main driver class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            Console.WriteLine($"Sum of SubArrays: {SubArraySum(arr, n)}");
            Console.WriteLine("The program execution has completed. You can press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This method calculates the sum of sub-arrays.
        /// </summary>
        /// <param name="array">The original array from which to calculate the sums of sub arrays.</param>
        /// <param name="n">The number of sub arrays.</param>
        /// <returns>The sum of all subarrays.</returns>
        public static long SubArraySum(int[] array, int n)
        {
            long result = 0;

            // Computing the sum of the subarrays with a formula
            for (int i = 0; i < n; i++)
            {
                result += array[i] * (i + 1) * (n - i);
            }

            return result;
        }
    }
}