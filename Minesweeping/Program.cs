// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace Minesweeping
{
    using System;

    /// <summary>
    /// This is the main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            // This is the input
            bool[][] matrix = new bool[3][] { new bool[]{ true, false, false },
                                        new bool[]{ false, true, false },
                                        new bool[]{ false, false, false } };

            int[][] result = Minesweeper(matrix);

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Console.Write(result[i][j] + " "); 
                }

                Console.WriteLine(); 
            }

            Console.ReadKey(); 
        }

        private static int[][] Minesweeper(bool[][] matrix)
        {
            int[][] result = new int[matrix.Length][];
            int[] ii = new int[] { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] jj = new int[] { -1, 0, 1, 1, 1, 0, -1, -1 };

            int count;

            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new int[matrix[i].Length]; 
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    count = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        if (0 <= i + ii[k] && i + ii[k] < matrix.Length && 0 <= j + jj[k] && j + jj[k] < matrix[i].Length && matrix[i + ii[k]][j + jj[k]])
                        {
                            count += 1;
                        }
                    }
                    result[i][j] = count;
                }
            }

            return result; 
        }
    }
}