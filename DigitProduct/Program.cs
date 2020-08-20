// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DigitProduct
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This is the main class for the project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            var product = 12;

            int digProd = DigitsProduct(product);
            Console.WriteLine($"For {product} = {digProd}");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }

        static int DigitsProduct(int product)
        {
            List<int> intList = new List<int>();
            int ans = 0;

            if (product == 0) return 10;
            if (product == 1) return 1; 

            for (int d = 9; d > 1; d--)
            {
                while (product % d == 0)
                {
                    product /= d;
                    intList.Add(d);
                }
            }

            if (product > 1) return -1; 
            for (int i = intList.Count - 1; i >= 0; i--)
            {
                ans = 10 * ans + intList[i]; 
            }

            return ans;
        }
    }
}