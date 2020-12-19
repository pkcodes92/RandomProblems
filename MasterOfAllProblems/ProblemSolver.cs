using System;
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
    }
}