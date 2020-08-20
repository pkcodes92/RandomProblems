// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace BubbleSort
{
    using System;
    using System.Linq;

    /// <summary>
    /// This is the main class for the program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);

            int swapCount = BubbleSortArray(a, n);

            Console.WriteLine("Array is sorted in {0} swaps.", swapCount);
            Console.WriteLine("First Element: {0}", a.First());
            Console.WriteLine("Last Element: {0}", a.Last());
        }

        /// <summary>
        /// This method performs the bubble sort algorithm implementation.
        /// </summary>
        /// <param name="arr">The input array.</param>
        /// <param name="n">The length of the array.</param>
        /// <returns>Having the number of swaps taken to sort the array.</returns>
        public static int BubbleSortArray(int[] arr, int n)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (n == 0)
            {
                throw new ArgumentNullException(nameof(n));
            }

            int i, j, temp;
            int swappedCount = 0;
            bool swapped;

            for (i = 0; i < n - 1; ++i)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                        swappedCount++;
                    }
                }

                // If no elements were swapped by inner loop, then break
                if (swapped == false)
                    break;
            }

            return swappedCount;
        }
    }
}