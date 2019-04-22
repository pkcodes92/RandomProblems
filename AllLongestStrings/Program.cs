using System;
using System.Collections;
using System.Collections.Generic;

namespace AllLongestStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = new string[] { "aba", "aa", "ad", "vcd", "aba" };
            Console.WriteLine("Input Array: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Output: ");

            string[] outputArray = AllLongestStrings(inputArray);
            string[] outputArray2 = AllLongStrings(inputArray); 

            for (int j = 0; j < outputArray.Length; j++)
            {
                Console.Write(outputArray[j] + " ");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Gets the longest strings inside of the input string
        /// </summary>
        /// <param name="inputArray">The string that the user enters</param>
        /// <returns>An array (or even a list) of all the longest elements inside of the user input string</returns>
        static string[] AllLongestStrings(string[] inputArray)
        {
            int max = 0;
            Queue stringQ = new Queue();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > max)
                {
                    stringQ.Clear();
                    stringQ.Enqueue(inputArray[i]);
                    max = inputArray[i].Length;
                }
                else if (inputArray[i].Length == max)
                {
                    stringQ.Enqueue(inputArray[i]);
                }
            }

            string[] strL = new string[stringQ.Count];
            for (int i = 0; i < strL.Length; i++)
            {
                strL[i] = (string)stringQ.Dequeue(); 
            }

            return strL; 
        }

        /// <summary>
        /// The same purpose as <see cref="AllLongestStrings(string[])"/>
        /// </summary>
        /// <param name="inputArray">Returns the longest string inside of the user input string</param>
        /// <returns>A string array</returns>
        static string[] AllLongStrings(string[] inputArray)
        {
            int max = 0;

            List<string> lst = new List<string>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > max)
                {
                    lst.Add(inputArray[i]);
                    max = inputArray[i].Length; 
                }
                else if (inputArray[i].Length == max)
                {
                    lst.Add(inputArray[i]);
                }
            }

            var output = lst.ToArray();
            return output; 
        }
    }
}