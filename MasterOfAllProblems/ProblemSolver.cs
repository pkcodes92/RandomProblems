using System;
using System.Collections;
using System.Globalization;

namespace MasterOfAllProblems
{
    public class ProblemSolver
    {
        public static void AbsoluteDifference()
        {
            Console.WriteLine("Please provide a value for n: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(FindDifference(n));
        }

        public static void AcronymMaker()
        {
            Console.WriteLine("Please enter a string to consolidate into an acronym: ");
            var inputString = Console.ReadLine();

            Console.WriteLine($"Acronym: {Abbreviate(inputString)}");
        }

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

        public static void AlternatingSums()
        {

        }

        public static void ArrayElementsMultiplication()
        {

        }

        public static void ArrayLeftRotation()
        {

        }

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
    }
}