/*
 * Problem: Given array of integers, remove each kth element from it.
 */

namespace ExtractElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Standard test case
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 3;

            int[] outputArray = ExtractEachKth(inputArray, k);
            foreach (int item in outputArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }

        static int[] ExtractEachKth(int[] inputArray, int k)
        {
            return inputArray.Where((x, y) => y % k != k - 1).ToArray();
        }
    }
}
