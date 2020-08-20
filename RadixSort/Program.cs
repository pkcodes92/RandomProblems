// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace RadixSort
{
    using System;

    /// <summary>
    /// Write a C# program to sort a list of elements using the Radix Sort Algorithm
    /// 
    /// Radix sort is a non-comparative sorting algorithm that sorts data with integer keys
    /// by grouping keys by the individual digits which are share the same significant position
    /// and value.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nOriginal Array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            Sort(arr);
            Console.WriteLine("\nSorted Array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This method sorts the array.
        /// </summary>
        /// <param name="arr">The input array to be sorted.</param>
        public static void Sort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; shift--)
            {
                j = 0;
                for (i = 0; i < arr.Length; i++)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }
    }
}