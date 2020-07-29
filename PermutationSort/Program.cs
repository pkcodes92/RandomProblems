// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace PermutationSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Write a C# program to sort a list of elements using Permutation Sort.
    /// 
    /// Permutation sort, proceeds by generating the possible permutations of the input array/list until
    /// discovering the sorted one.
    /// 
    /// Notes: 
    /// * This actually employs the concept that is tied with method overloading
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            string str = "ABC";
            char[] arr = str.ToCharArray();
            GetPermutation(arr);

            Console.WriteLine("The program execution has completed, you may press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This method will get the permutations that are available.
        /// </summary>
        /// <param name="list">The list of characters, stored as an array.</param>
        public static void GetPermutation(char[] list)
        {
            int x = list.Length - 1;
            GetPermutation(list, 0, x); 
        }

        /// <summary>
        /// This is a method of getting permutations, and possibly an overload.
        /// </summary>
        /// <param name="list">The list of characters.</param>
        /// <param name="k">The starting index.</param>
        /// <param name="m">The ending index.</param>
        public static void GetPermutation(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.WriteLine(list);
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPermutation(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
            }
        }

        /// <summary>
        /// This method will swap two characters.
        /// </summary>
        /// <param name="a">The first character to swap.</param>
        /// <param name="b">The second character to swap.</param>
        public static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            // Below are exclusive-OR
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}