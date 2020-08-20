// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ReturnLongestWord
{
    using System;
    using System.Linq;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            var text = "Ready, steady, go!";
            string output = LongestWord(text);

            Console.WriteLine($"The longest word is: {output}");
            Console.ReadKey();
        }

        /// <summary>
        /// This method returns the longest word.
        /// </summary>
        /// <param name="text">The sentence to analyze.</param>
        /// <returns>The longest word in the sentence.</returns>
        public static string LongestWord(string text)
        {
            string[] s = text.Split(new char[]
            {
                ']',
                '[',
                ',',
                '!',
                ' '
            }, StringSplitOptions.RemoveEmptyEntries);

            return s.OrderByDescending(x => x.Length).First();
        }
    }
}