// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ClosestToLimit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the limit integer: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int val1 = CalcDifference(x, limit);
            int val2 = CalcDifference(y, limit);

            int finalResult = FindResult(val1, val2, x, y);

            Console.WriteLine("Closest to {0} is {1}", limit, finalResult);

            Console.ReadKey();
        }

        /// <summary>
        /// This is to find the difference between two numbers
        /// </summary>
        /// <param name="x">User provided input for the first number</param>
        /// <param name="limit">User provided input for the limit integer</param>
        /// <returns>A difference of limit from the variable x</returns>
        static int CalcDifference(int x, int limit)
        {
            return Math.Abs(x - limit); 
        }

        /// <summary>
        /// Finding which number was closest to the limit that was provided by the
        /// user at the time that this console application runs
        /// </summary>
        /// <param name="val1">Result between the first integer and the limit</param>
        /// <param name="val2">Result between the second integer and the limit</param>
        /// <param name="x">The first integer provided by the user</param>
        /// <param name="y">The second integer provided by the user</param>
        /// <returns>An integer which is the number that is closest to the limit</returns>
        static int FindResult(int val1, int val2, int x, int y)
        {
            if (val1 == val2)
            {
                return 0; 
            }
            else
            {
                if (val1 < val2)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
        }
    }
}