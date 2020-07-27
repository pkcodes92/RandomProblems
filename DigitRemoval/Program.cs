// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DigitRemoval
{
    using System;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specifc arguments.</param>
        public static void Main(string[] args)
        {
            var n = 152;
            int maxValue = DeleteDigit(n);

            Console.WriteLine($"Input value is: {n}");
            Console.WriteLine($"Value is {maxValue}");

            Console.WriteLine("Program execution has now completed - you may press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This method will delete the digit.
        /// </summary>
        /// <param name="n">Digit deleted.</param>
        /// <returns>A final integer which is the maximum value.</returns>
        public static int DeleteDigit(int n)
        {
            string s = n.ToString();
            int i; 
            for (i = 0; i < s.Length - 1; i++)
            {
                if (s[i] < s[i + 1])
                    break;
            }

            return Convert.ToInt32(s.Remove(i, 1));
        }
    }
}