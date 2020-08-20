// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace LuckyNumbers
{
    using System;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method/main point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int n = 1230;

            string nStr = n.ToString();

            int sumFirstHalf = 0, sumSecHalf = 0; 

            for (int i = 0; i < nStr.Length / 2; i++)
            {
                sumFirstHalf += Convert.ToInt32(nStr[i]); 
            }

            for (int j = nStr.Length / 2; j < nStr.Length; j++)
            {
                sumSecHalf += Convert.ToInt32(nStr[j]);
            }

            Console.WriteLine(sumFirstHalf == sumSecHalf);

            Console.WriteLine("Program execution has completed, you can press any key to exit");
            Console.ReadKey(); 
        }
    }
}