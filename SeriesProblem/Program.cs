// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace SeriesProblem
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
        /// <param name="args">Project specific arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of queries, q: ");
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                int n = int.Parse(tokens[2]);

                for (int j = 0; j < n; j++)
                {
                    Console.Write(DetermineSeriesNTerms(a, b, n) + " ");
                }

                Console.WriteLine(); 
            }

            Console.ReadKey(); 
        }

        /// <summary>
        /// Determines each term in the series that is specified by the user
        /// when the user provides values for a, b, and n
        /// </summary>
        /// <param name="a">Input for the initial term</param>
        /// <param name="b">Input for a multiplier</param>
        /// <param name="n">Input to represent the number of terms to limit</param>
        private static int DetermineSeriesNTerms(int a, int b, int n)
        {
            int sum = a;

            for (int z = n; z >= 0; z--)
            {
                sum = sum + ((int)Math.Pow(2, z) * b); 
            }

            return sum;
        }
    }
}