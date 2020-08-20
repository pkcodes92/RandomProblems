// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace MultiplicationTable
{
    using System;

    /// <summary>
    /// This is the driver class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project command line specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int product;

            Console.WriteLine("The multiplication table for: {0}", N);

            // Having 12 iterations happen for the loop
            for (int i = 1; i < 13; i++)
            {
                product = N * i;
                Console.WriteLine(string.Format("{0} x {1} = {2}", N, i, product));
            }

            Console.WriteLine("Program execution has finished, you may press any key to exit.");
            Console.ReadKey(); 
        }
    }
}