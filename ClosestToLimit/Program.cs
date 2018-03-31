/*
 * Author   : Pranav S. Krishnamurthy
 * 
 * Date     : 31st March 2018
 * 
 * Purpose  : To create a C# console application that will take three integers:
 *            x, y, and limit; and then determine which number x or y is closest
 *            to the limit integer and prints out the limit integer
 */

using System;

namespace ClosestToLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the limit integer: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int val1 = CalcDifference(x, limit);
            int val2 = CalcDifference(y, limit);

            int finalResult = FindResult(val1, val2, x, y);
        }

        static int CalcDifference(int x, int limit)
        {
            return Math.Abs(x - limit); 
        }

        static int FindResult(int val1, int val2, int x, int y)
        {
            if (val1 == val2)
            {
                return 0; 
            }
            else
            {
                if (val1 < val2)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
        }
    }
}
