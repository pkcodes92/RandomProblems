// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace MiniMaxSum
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
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            FindMiniMaxSum(arr);

            Console.ReadKey();
        }

        private static void FindMiniMaxSum(int[] arr)
        {
            long[] a = new long[5];
            long sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] += (long)arr[i];
                sum += a[i];
            }

            Array.Sort(a);
            Console.WriteLine((sum - a[a.Length - 1]) + " " + (sum - a[0]));
        }
    }
}