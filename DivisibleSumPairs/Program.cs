// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DivisibleSumPairs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = int.Parse(nk[0]);

            int k = int.Parse(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = FindDivisiblePairs(n, k, ar);

            Console.WriteLine($"There are {result} pairs for the provided array");
            Console.WriteLine("Program execution has completed - you may press any key to exit");
            Console.ReadKey(); 
        }

        /// <summary>
        /// This method will find the divisible pairs.
        /// </summary>
        /// <param name="n">The value of n.</param>
        /// <param name="k">The value of k.</param>
        /// <param name="ar">The array of integers.</param>
        /// <returns>The number of divisible pairs.</returns>
        public static int FindDivisiblePairs(int n, int k, int[] ar)
        {
            var divisiblePairCnt = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i+1; j < ar.Length; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        divisiblePairCnt++;
                    }
                }
            }

            return divisiblePairCnt; 
        }
    }
}