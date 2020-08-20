// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace LuhnValidator
{
    using System;

    /// <summary>
    /// This is the main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method, and the main entry point of execution at runtime.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            var sampleNumber = "5177 0547 5647 2315";
            var expectedResult = true;

            Console.WriteLine(expectedResult == Luhn.IsValid(sampleNumber) ? "Yahtzee, it works!" : "Not quite working yet");
            Console.WriteLine("The program execution has ended - please press any key to exit");

            Console.ReadKey();
        }
    }
}