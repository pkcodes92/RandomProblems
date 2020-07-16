// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ContainsDuplicates
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 1 };

            bool duplicates = ContainDups(a);

            Console.WriteLine(duplicates);

            Console.WriteLine("Progam execution has finished, you may now press any key to exit");
            Console.ReadKey(); 
        }

        /// <summary>
        /// Method that would be able to find duplicate elements inside of an array
        /// </summary>
        /// <param name="a">An integer array</param>
        /// <returns>A true or false value that would signal if the array has duplicate values</returns>
        static bool ContainDups(int[] a)
        {
            Dictionary<int, int> b = new Dictionary<int, int>();
            foreach (int x in a)
            {
                if (!b.ContainsKey(x))
                {
                    b.Add(x, 1); 
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
