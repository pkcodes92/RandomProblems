// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace SumTest
{
    using System;

    /// <summary>
    /// This is the main class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine(TestSum(1, 2));
            Console.WriteLine(TestSum(2, 3));
            Console.WriteLine(TestSum(3, 3));

            Console.WriteLine("Program has completed execution, press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Function that will return the sum of two numbers in the following conditions: 
        /// - The sum is tripled if the two input numbers are equal
        /// - Otherwise return the sum of the two numbers
        /// </summary>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>The sum of the two numbers</returns>
        private static int TestSum(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}