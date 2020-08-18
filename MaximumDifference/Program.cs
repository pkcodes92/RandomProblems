// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace MaximumDifference
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The function assumes that there are at least
        /// two elements in the array. 
        /// </summary>
        /// <param name="arr">The input array</param>
        /// <param name="arr_size">Size of the array input</param>
        /// <returns>Function will return a negative value if the array is sorted in
        /// decreasing order. Also it would return 0 if the elements are equal</returns>
        public static int MaxDiff(int[] arr, int arr_size)
        {
            int max_diff = arr[1] - arr[0];
            int min_element = arr[0];

            int i;
            for (i = 1; i < arr_size; i++)
            {
                if (arr[i] - min_element > max_diff)
                {
                    max_diff = arr[i] - min_element;
                }

                if (arr[i] < min_element)
                {
                    min_element = arr[i];
                }
            }

            return max_diff;
        }

        /// <summary>
        /// The main entry point at runtime.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] arr = { 14, 55, 76, 5, 9, 28, 22 };
            int size = arr.Length;
            Console.Write("MaximumDifference is: " + MaxDiff(arr, size));

            Console.ReadKey();
        }
    }
}