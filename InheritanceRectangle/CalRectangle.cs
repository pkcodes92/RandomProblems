// <copyright file = "CalRectangle.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace InheritanceRectangle
{
    using System;

    /// <summary>
    /// This is the main class for the execution.
    /// </summary>
    public static class CalRectangle
    {
        /// <summary>
        /// This is the main method/entry point of execution.
        /// </summary>
        /// <param name="args">The project specific arguments.</param>
        public static void Main(string[] args)
        {
            TableTop t = new TableTop(7.5, 8.04);
            t.Display();

            Console.WriteLine("Program execution has finished, you may now press any key to exit");
            Console.ReadKey(); 
        }
    }
}