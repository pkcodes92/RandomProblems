using System;
using System.Collections;
using System.Globalization;

namespace MasterOfAllProblems
{
    /// <summary>
    /// This is the problem solver class.
    /// </summary>
    public class ProblemSolver
    {
        /// <summary>
        /// This method will calculate the absolut difference.
        /// </summary>
        public static void AbsoluteDifference()
        {
            Console.WriteLine("Please provide a value for n: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(FindDifference(n));
        }

        /// <summary>
        /// This method will create an acronym out of a string.
        /// </summary>
        public static void AcronymMaker()
        {
            Console.WriteLine("Please enter a string to consolidate into an acronym: ");
            var inputString = Console.ReadLine();

            Console.WriteLine($"Acronym: {Abbreviate(inputString)}");
        }

        /// <summary>
        /// This method will extract all of the longest strings from an array of strings.
        /// </summary>
        public static void AllLongestStrings()
        {
            string[] inputArray = new string[] { "aba", "aa", "ad", "vcd", "aba" };
            string[] outputArray = FindLongestStrings(inputArray);

            Console.WriteLine("Results: ");
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.Write(outputArray[i] + " ");
            }
        }

        /// <summary>
        /// This method will calculate the alternating sums inside of an array of integers.
        /// </summary>
        public static void AlternatingSums()
        {
            int[] a = new int[] { 40, 50, 60, 80, 10 };
            int[] weights = FindAlternatingSums(a);

            Console.WriteLine("Results:");
            for (int i = 0; i < weights.Length; i++)
            {
                Console.Write(weights[i] + " ");
            }
        }

        /// <summary>
        /// This method will multiply the elements between arrays.
        /// </summary>
        public static void ArrayElementsMultiplication()
        {
            int[] first = { 1, 3, -5, 4 };
            int[] second = { 1, 4, -5, -2 };

            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", second));

            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

            for (int i = 0; i < first.Length; i++)
            {
                Console.WriteLine(first[i] * second[i] + " ");
            }

            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// This method will rotate an array to the left.
        /// </summary>
        public static void ArrayLeftRotation()
        {

        }

        /// <summary>
        /// This method will replace one element in an array.
        /// </summary>
        public static void ArrayReplacement()
        {

        }

        /// <summary>
        /// Method that will calculate the absolute difference btween n and 51. 
        /// If n is greater than 51 return triple the absolute difference.
        /// </summary>
        /// <param name="n">Value passed through the console.</param>
        /// <returns>Absolute difference.</returns>
        private static int FindDifference(int n)
        {
            const int x = 51;

            if (n > x)
            {
                return (n - x) * 3;
            }
            else
            {
                return x - n;
            }
        }

        private static string Abbreviate(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var parts = input.Split(new char[] { ' ', '-', '_' });

            string res = "";
            foreach (var p in parts)
            {
                if (p.Length > 0)
                {
                    res += p.ToUpper()[0];
                }
            }

            return res;
        }

        private static string[] FindLongestStrings(string[] inputArray)
        {
            if (inputArray is null)
            {
                throw new ArgumentNullException(nameof(inputArray));
            }

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

        private static int[] FindAlternatingSums(int[] a)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            int[] weights = new int[2];

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    weights[0] += a[i];
                }

                if (i % 2 == 1)
                {
                    weights[1] += a[i];
                }
            }

            return weights;
        }
    }
}