// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace SortedSearch
{
    using System;

    /// <summary>
    /// This is the main class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method/main entry point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine(CountNumbers(new int[] { 1, 3, 5, 6, 7 }, 4));
            Console.WriteLine("The program has finished execution - you can press any key to exit");
            Console.ReadKey();
        }

        private static int CountNumbers(int[] sortedArray, int lessThan)
        {
            var validCnt = 0;

            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (sortedArray[i] < lessThan)
                {
                    validCnt++;
                }
            }

            return validCnt;
        }
    }
}