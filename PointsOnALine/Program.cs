// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace PointsOnALine
{
    using System;

    /// <summary>
    /// Author   : Pranav S. Krishnamurthy
    /// Date     : 2nd April 2018
    /// Purpose  : To create a program that determines whether or not
    /// 3 points that are entered by the user fall on the same line.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method of this project.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3;
            double slope1, slope2, slope3;

            Console.WriteLine("Enter the values for x1 and y1 for the first point");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values for x2 and y2 for the second point");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values for x3 and y3 for the third point");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            slope1 = CalcDeltaY(y2, y1) / CalcDeltaX(x2, x1);
            slope2 = CalcDeltaY(y3, y1) / CalcDeltaX(x3, x1);
            slope3 = CalcDeltaY(y3, y2) / CalcDeltaX(x3, x2);

            if (slope1 == slope2 && slope1 == slope3)
            {
                Console.WriteLine("All points fall on the same line");
            }
            else
            {
                Console.WriteLine("All points DO NOT fall on the same line");
            }

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }

        private static int CalcDeltaX(int x2, int x1)
        {
            return x2 - x1;
        }

        private static int CalcDeltaY(int y2, int y1)
        {
            return y2 - y1;
        }
    }
}