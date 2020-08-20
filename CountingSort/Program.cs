// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace CountingSort
{
    using System;
    using System.Linq;

    /// <summary>
    /// Write a C# program to sort a list of elements using the Counting sort
    /// algorithm. In computer science, counting sort is an algorithm for sorting
    /// a collection of objects according to keys that are small integers; that is, 
    /// it is an integer sorting algorithm. It operates by counting the number of
    /// objects that have each a distinct key value, and using arithmetic on those
    /// counts to determine the positions of each key value in the output sequence. 
    /// 
    /// Its running time is linear in the number of items and the difference between
    /// the maximum and minimum key values, so it is only suitable for direct use in
    /// situations where the variation in keys is not significantly greater than the
    /// number of items. However, it is oftent used a subroutine in another sorting
    /// algorithm, radix sort, that can handle larger keys more efficiently.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[] array = new int[10] { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 };

            Console.WriteLine("\n" + "Original Array : ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            int[] sortedArray = new int[array.Length];

            // find the smallest and largest values
            int minVal = array[0];
            int maxVal = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                }
                else if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }

            // Init the array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // Properly initialize everything - related to frequencies
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            // Recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Length - 1; i >= 0; --i)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            Console.WriteLine("\n" + "Sorted array :");
            foreach (int sortedItem in sortedArray)
            {
                Console.Write(sortedItem + " ");
            }

            Console.Write(Environment.NewLine);

            Console.WriteLine("The program execution has completed, you may now press any key to exit");
            Console.ReadKey(); 
        }
    }
}