// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace AvoidingObstacles
{
    using System;
    using System.Linq;

    /// <summary>
    /// This is the program class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] inputArray = new int[] { 5, 3, 6, 7, 9 };

            int result = AvoidObstacles(inputArray);

            Console.WriteLine($"Final result: {result}");

            Console.WriteLine("Program execution has completed - you may now press any key to exit");
            Console.ReadKey(); 
        }

        /// <summary>
        /// This method will be able to avoid necessary obstacles.
        /// </summary>
        /// <param name="inputArray">The incoming input array.</param>
        /// <returns>An integer being returned.</returns>
        public static int AvoidObstacles(int[] inputArray)
        {
            if (inputArray is null)
            {
                throw new ArgumentNullException(nameof(inputArray));
            }

            var list = inputArray.ToList();

            for (int i = 1; i < list.Max() + 1; i++)
            {
                if (list.All(n => n % i != 0))
                {
                    return i; 
                }
            }

            return list.Max() + 1; 
        }
    }
}