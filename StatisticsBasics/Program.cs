// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StatisticsBasics
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);

            double mean = GetMean(a);
            double median = GetMedian(a);
            int mode = GetMode(a);

            Console.WriteLine($"Mean is: {mean}");
            Console.WriteLine($"Median is: {median}");
            Console.WriteLine($"Mode is: {mode}");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey(); 
        }

        private static double GetMean(int[] a)
        {
            int sum = 0;
            int size = a.Length;
            double mean;
            foreach (int item in a)
            {
                sum += item;
            }
            mean = Convert.ToDouble(sum) / size;

            return mean;
        }

        private static double GetMedian(int[] a)
        {
            double median;
            int size = a.Length;
            int[] copy = a;

            // Having the array sorted prior to finding
            // out the median
            Array.Sort(copy);

            // Making sure to calculate the median correctly
            if (size % 2 == 0)
            {
                median = Convert.ToDouble((copy[size / 2 - 1] + copy[size / 2]) / 2);
            }
            else
            {
                median = Convert.ToDouble(copy[(size - 1) / 2]);
            }

            return median;
        }

        private static int GetMode(int[] a)
        {
            int mode = 0;
            int size = a.Length;
            int[] copy = a;
            Array.Sort(copy);
            int count = 0, max = 0;
            int current = copy[0];

            for (int i = 0; i < size; i++)
            {
                if (copy[i] == current)
                {
                    count++; 
                }
                else
                {
                    count = 1;
                    current = copy[i];
                }

                if (count > max)
                {
                    max = count;
                    mode = copy[i];
                }
            }

            return mode;
        }
    }
}