// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace CorrelationCoefficient
{
    using System;

    /// <summary>
    /// This is the main driver class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">The project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] X = { 15, 18, 21, 24, 27 };
            int[] Y = { 25, 25, 27, 31, 32 };

            // Find the size of the array.
            int n = X.Length;

            // Showing the output
            Console.Write(Math.Round(CalcCorrelationCoefficient(X, Y, n) * 1000000.0) / 1000000.0);

            // Generic message
            Console.WriteLine("Program has ended execution. Press any key to exit");
            Console.ReadKey();
        }

        private static float CalcCorrelationCoefficient(int[] X, int[] Y, int n)
        {
            int sum_X = 0, sum_Y = 0, sum_XY = 0;
            int squareSum_X = 0, squareSum_Y = 0;

            for (int i = 0; i < n; i++)
            {
                // Sum of elements of array X.
                sum_X = sum_X + X[i];

                // Sum of elements of array Y.
                sum_Y = sum_Y + Y[i];

                // Sum of X[i] * Y[i]
                sum_XY = sum_XY + X[i] * Y[i];

                // Sum of square of array elements
                squareSum_X = squareSum_X + X[i] * X[i];
                squareSum_Y = squareSum_Y + Y[i] * Y[i];
            }

            // use formula for calculating correlation  
            // coefficient. 
            float corr = (n * sum_XY - sum_X * sum_Y) /
                         (float)(Math.Sqrt((n * squareSum_X -
                         sum_X * sum_X) * (n * squareSum_Y -
                         sum_Y * sum_Y)));

            return corr;
        }
    }
}