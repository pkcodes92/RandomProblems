// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace LinkedListTutorial
{
    using System;

    /// <summary>
    /// Author   : Pranav S. Krishnamurthy
    /// Date     : 4th April 2018
    /// Purpose  : Creating a C# console application to be able to properly show the implementation of a LinkedList.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method/entry point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            LinkedList lnkList = new LinkedList();
            lnkList.PrintAllNodes();
            Console.WriteLine();

            lnkList.AddAtLast(12);
            lnkList.AddAtLast("John");
            lnkList.AddAtLast("Peter");
            lnkList.AddAtLast(34);
            lnkList.PrintAllNodes();
            Console.WriteLine();

            lnkList.AddAtStart(55);
            lnkList.PrintAllNodes();
            Console.WriteLine();

            lnkList.RemoveFromStart();
            lnkList.PrintAllNodes();

            Console.WriteLine("Program execution has completed, press any key to exit");
            Console.ReadKey();
        }
    }
}