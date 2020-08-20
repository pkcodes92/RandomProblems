// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace BoxBlurring
{
    using System;
    using System.Linq;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[][] image = new int[3][] { new int[] { 1, 1, 1 },
                                            new int[] { 1, 7, 1 },
                                            new int[] { 1, 1, 1 } };

            int[][] result = BoxBlur(image);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey(); 
        }

        /// <summary>
        /// This method will bur the boxes.
        /// </summary>
        /// <param name="image"></param>
        /// <returns>A 2D integer array of the boxes being blurred.</returns>
        public static int[][] BoxBlur(int[][] image)
        {
            if (image is null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            int[][] result = new int[image.Length - 2][];
            int[] ii = new int[] { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] jj = new int[] { -1, 0, 1, 1, 1, 0, -1, -1 };

            int temp;

            for (int i = 1; i < image.Length - 1; i++)
            {
                result[i - 1] = new int[image[i].Length - 2];
                for (int j = 1; j < image[i].Length - 1; j++)
                {
                    temp = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        if (0 <= i + ii[k] && ii[k] < image.Length && 0 <= j + jj[k] && j + jj[k] < image[i].Length)
                        {
                            temp += image[i + ii[k]][j + jj[k]];
                        }
                    }

                    result[i - 1][j - 1] = (image[i][j] + temp) / 9;
                }
            }

            return result;
        }
    }
}