// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace QuadraticSolver
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            QuadraticRoots.Read();
            QuadraticRoots.Compute();

            Console.WriteLine("Program execution has completed, press any key to exit");
            Console.ReadKey(); 
        }
    }
}