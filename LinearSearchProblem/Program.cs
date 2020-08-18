// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace LinearSearchProblem
{
    using System;

    /// <summary>
    /// This is the main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point of execution/driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 27, 80, 30, 60, 50, 110, 100, 130, 170 };

            foreach (int elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Now provide a value to find it's location from the above: ");
            int x = int.Parse(Console.ReadLine());

            int indexLocation = FindLocation(arr, x);

            Console.WriteLine($"{x} is located at position {indexLocation}");
            Console.WriteLine("Program has finished execution, please press any key to exit");
            Console.ReadKey();
        }

        private static int FindLocation(int[] arr, int x)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                // Return the index of the element
                if (arr[i] == x)
                {
                    return i;
                }
            }

            // By returning -1, it would signify that the element
            // does not exist in the array
            return -1;
        }
    }
}