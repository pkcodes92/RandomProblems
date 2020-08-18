// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ElectionWinners
{
    using System;
    using System.Linq;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method, the main entry point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] votesIn = new int[] { 2, 3, 5, 2 };
            int k = 2;

            int result = ElectionsWinners(votesIn, k);

            Console.WriteLine($"The final result: {result}");

            Console.ReadKey(); 
        }

        /// <summary>
        /// This method will extract the election winners.
        /// </summary>
        /// <param name="votes">The input array of the votes.</param>
        /// <param name="k">The number of winners to choose.</param>
        /// <returns>The winners of the election.</returns>
        public static int ElectionsWinners(int[] votes, int k)
        {
            int max = votes.Max();
            if (k == 0)
            {
                return votes.Count(x => x == max) > 1 ? 0 : 1;
            }

            return votes.Count(x => x + k > max);
        }
    }
}