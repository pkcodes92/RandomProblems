// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace OddArraySum
{
    using System;
    using System.Linq;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Provide a list of space separated integers: ");
            string[] temp = Console.ReadLine().Split(' ');
            int[] inputArray = Array.ConvertAll(temp, int.Parse);

            int oddArraySum = FindSum(inputArray);
            Console.WriteLine($"The odd sum of {inputArray} = {oddArraySum}");
            Console.WriteLine("The program has finished execution - press any key to exit");
            Console.ReadKey(); 
        }

        private static int FindSum(int[] inputArray)
        {
            var filteredList = from numbers in inputArray
                               where (numbers % 2) == 1
                               select numbers;

            int[] filteredArray = filteredList.ToArray();
            var sum = 0; 

            if (filteredArray.Length > 1)
            {
                sum = filteredArray.Sum(); 
            }
            else
            {
                sum = 0; 
            }

            return sum; 
        }
    }
}