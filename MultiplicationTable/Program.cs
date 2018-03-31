/*
 * Author   : Pranav S. Krishnamurthy
 * 
 * Date     : 31st March 2018
 * 
 * Purpose  : To create a program that will print out the multiplication table for
 *            a user provided integer
 */

using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int product;

            Console.WriteLine("The multiplication table for: {0}", N);

            // Having 12 iterations happen for the loop
            for (int i = 1; i < 13; i++)
            {
                product = N * i;
                Console.WriteLine(string.Format("{0} x {1} = {2}", N, i, product));
            }

            Console.ReadKey(); 
        }
    }
}