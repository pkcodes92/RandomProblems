// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace BogoSort
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary>
    /// The main class for this console application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            List<int> inputList = new List<int>() { 2, 1, 3, 0, 5 };
            Console.WriteLine("Sorting...");

            Bogo_Sort(inputList, true, 5);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This is the main method for the Bogo_sort algorithm implementation.
        /// </summary>
        /// <param name="list">The input list.</param>
        /// <param name="announce">Boolean determining whether or not console output should be displayed.</param>
        /// <param name="delay">What is the delay in between each time there is console output.</param>
        static void Bogo_Sort(List<int> list, bool announce, int delay)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            int iteration = 0;
            while (!IsSorted(list))
            {
                if (announce)
                {
                    PrintIteration(list, iteration);
                }

                if (delay != 0)
                {
                    Thread.Sleep(Math.Abs(delay));
                }

                list = Remap(list);
                iteration++;
            }

            PrintIteration(list, iteration);
            Console.WriteLine();
            Console.WriteLine("Bogo_sort completed after {0} iterations", iteration);

            Console.WriteLine("Program has completed execution, you may now press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This is to print the current iteration of the algorithm.
        /// </summary>
        /// <param name="list">The input list of numbers.</param>
        /// <param name="iteration">The current iteration.</param>
        static void PrintIteration(List<int> list, int iteration)
        {
            Console.Write("Bogo_sort iteration {0}: ", iteration);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// This function would check whether or not the list is being sorted correctly.
        /// </summary>
        /// <param name="list">The input list.</param>
        /// <returns>A standard boolean value true or false.</returns>
        static bool IsSorted(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// This function generates a new list that will remap the permutations.
        /// </summary>
        /// <param name="list">The input list.</param>
        /// <returns>A list of integer values.</returns>
        static List<int> Remap(List<int> list)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            int temp;
            List<int> newList = new List<int>();
            Random r = new Random();

            while (list.Count > 0)
            {
                temp = (int)r.Next(list.Count);
                newList.Add(list[temp]);
                list.RemoveAt(temp);
            }

            return newList;
        }
    }
}