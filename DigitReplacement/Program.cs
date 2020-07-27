// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DigitReplacement
{
    using System;
    using System.Linq;

    /// <summary>
    /// This is the main driver class.
    /// 
    /// Problem: digitDegree is all about taking the number of digits required in a number and finding out
    /// how many digits are required to turn a multi-digit number into a single digit number.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int n = 5;

            int result = DigitDegree(n);

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Program execution has completed - you may now press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// The method which finds out the number of digits required to turn a multi-digit number into a single digit number.
        /// </summary>
        /// <param name="n">The number of condense.</param>
        /// <returns>The total number of moves.</returns>
        public static int DigitDegree(int n)
        {
            if (n < 10)
                return 0;

            var times = 0;
            var sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
            while (sum >= 10 || n >= 10)
            {
                times++;
                n = sum;
                sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
            }

            return times;
        }
    }
}
