// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace SumUpListNumbers
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// This is the main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main method rather the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            var inputString = "2 apples, 12 bananas";

            int totalCount = SumUpNumbers(inputString);
            Console.WriteLine($"{inputString} = {totalCount}");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This method will add the items in the list.
        /// </summary>
        /// <param name="inputString">The list of items.</param>
        /// <returns>The total number of items in the mixed list.</returns>
        public static int SumUpNumbers(string inputString)
        {
            int s = 0; 
            foreach(Match match in Regex.Matches(inputString, "[0-9]+"))
            {
                s += Convert.ToInt32(match.Value); 
            }

            return s; 
        }
    }
}