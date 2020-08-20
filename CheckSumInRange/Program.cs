// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace CheckSumInRange
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
            Console.WriteLine(CheckSum(10, 19));
            Console.WriteLine(CheckSum(10, 2));
            Console.WriteLine(CheckSum(10, 29));
            Console.WriteLine(CheckSum(12, 2));

            Console.WriteLine("The program has finished executing, you may now press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Finding the sum of two numbers and checking if the sum
        /// falls in between two numbers, 10 and 20 inclusive
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <returns>The actual sum, or the number 30</returns>
        private static int CheckSum(int a, int b)
        {
            int sum = a + b;
            if (10 >= sum && sum <= 20)
            {
                return 30; 
            }
            else
            {
                return a + b;
            }
        }
    }
}