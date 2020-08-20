// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace MeetupFinder
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            var dateTest = new Meetup(12, 2012);
            var expected = new DateTime(2012, 12, 7);

            Console.WriteLine(expected == dateTest.Day(DayOfWeek.Friday, Schedule.First) ? "Yahtzee" : "Not quite");
            Console.WriteLine("The program execution has completed - you can press any key to exit");

            Console.ReadKey();
        }
    }
}