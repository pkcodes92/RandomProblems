// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace AlternatingSums
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method for this program.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] a = new int[] { 40, 50, 60, 80, 10};

            int[] weights = FindAltSums(a);

            for (int i = 0; i < weights.Length; i++)
            {
                Console.Write(weights[i] + " ");
            }

            Console.WriteLine("Program execution has completed - you may know press any key to exit");
            Console.ReadKey(); 
        }

        /// <summary>
        /// This method will find the alternating sums.
        /// </summary>
        /// <param name="a">The array of integers for the input.</param>
        /// <returns>An integer array of sums.</returns>
        public static int[] FindAltSums(int[] a)
        {
            int[] weights = new int[2];

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    weights[0] += a[i];
                }

                if (i % 2 == 1)
                {
                    weights[1] += a[i];
                }
            }

            return weights;
        }
    }
}