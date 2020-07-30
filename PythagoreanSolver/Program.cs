// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace PythagoreanSolver
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The driver method for this project.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] intArray = Array.ConvertAll(arr_temp, int.Parse);

            if (intArray.Length == 2)
            {
                double hypotenuse = CalculateHypotenuse(intArray);
                Console.WriteLine($"Given the legs of {intArray[0]} and {intArray[1]}, the hypotenuse = {hypotenuse}"); 
            }
            else
            {
                Console.WriteLine("The input list is too large to calculate the hypotenuse! Try again later.");
            }

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }

        private static double CalculateHypotenuse(int[] input)
        {
            double a = Convert.ToDouble(input[0]);
            double b = Convert.ToDouble(input[1]);

            double c_squared = Math.Pow(a, 2) + Math.Pow(b, 2);

            return Math.Sqrt(c_squared);
        }
    }
}