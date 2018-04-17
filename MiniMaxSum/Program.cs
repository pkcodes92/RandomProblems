/*
 * Date : 6th April 2018
 * 
 * Purpose : To solve the mini-max sum from HackerRank
 *           in the language of C#
 */

using System;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            FindMiniMaxSum(arr);

            Console.ReadKey();
        }

        static void FindMiniMaxSum(int[] arr)
        {
            long[] a = new long[5];
            long sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] += (long)arr[i];
                sum += a[i];
            }

            Array.Sort(a);
            Console.WriteLine((sum - a[a.Length - 1]) + " " + (sum - a[0]));
        }
    }
}