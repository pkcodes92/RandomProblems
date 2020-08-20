// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace MatrixTraversal
{
    using System;

    /// <summary>
    /// This is the driver class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method/main entry point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value for m: ");

            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a value for n: ");

            int n = int.Parse(Console.ReadLine());

            int numberOfPaths = CountPaths(m, n); 

            Console.WriteLine($"There are {numberOfPaths} for the {m} x {n} matrix");

            var isSquare = (m == n);

            Console.WriteLine($"Is the {m} x {n} matrix a square matrix? {isSquare}");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");

            Console.ReadKey(); 
        }

        private static int CountPaths(int m, int n)
        {
            // Return 1 if it is the first row or first column
            if (m == 1 || n == 1)
            {
                return 1; 
            }

            // Recursively find the number of ways to reach the last cell.
            return CountPaths(m - 1, n) + CountPaths(m, n - 1);
        }
    }
}