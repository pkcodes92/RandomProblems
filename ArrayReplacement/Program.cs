// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ArrayReplacement
{
    using System;

    /// <summary>
    /// This is the program class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific based.</param>
        public static void Main(string[] args)
        {
            int[] inputArray = new int[] { 1, 2, 1 };

            int elemToReplace = 1;

            int substitutionElem = 3;

            int[] finalArray = ArrayReplace(inputArray, elemToReplace, substitutionElem);

            for (int i = 0; i < finalArray.Length; i++)
            {
                Console.Write(finalArray[i] + " ");
            }

            Console.WriteLine("Program execution has now terminated - you may press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// This is the method that will be called in order to perform the 
        /// operations
        /// </summary>
        /// <param name="inputArray">The input array containing integers</param>
        /// <param name="elemToReplace">An element that will be replaced in the integers</param>
        /// <param name="substitutionElem">What element is to be used for the substitution</param>
        /// <returns></returns>
        public static int[] ArrayReplace(int[] inputArray, int? elemToReplace, int? substitutionElem)
        {
            if (inputArray is null)
            {
                throw new ArgumentNullException(nameof(inputArray));
            }

            if (elemToReplace is null)
            {
                throw new ArgumentNullException(nameof(elemToReplace));
            }

            if (substitutionElem is null)
            {
                throw new ArgumentNullException(nameof(substitutionElem));
            }

            int[] temp = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == (int)elemToReplace)
                {
                    temp[i] += (int)substitutionElem;
                }
                else
                {
                    temp[i] += inputArray[i];
                }
            }

            return temp;
        }
    }
}