/*
 * Problem : A left rotation operation an array of size n shifts
 *           each of the array's elements 1 unit to the left. For
 *           example, if 2 left rotations are performed on [1, 2, 3, 4, 5],
 *           then the array would become [3, 4, 5, 1, 2]. Given
 *           an array of n integers and a number d, perform d left rotations
 *           on the array.  Then print the updated array as a single line
 *           of space-separated integers. 
 *           
 *  Source  : HackerRank/Cracking The Coding Interview
 *  
 *  Date    : 15th April 2018
 *  
 *  Project : ArrayLeftRotation
 */

using System;
using System.Collections.Generic;

namespace ArrayLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, z;

            // The input for the size of the array and the number of left rotations
            string[] tokens_in = Console.ReadLine().Split(' ');

            // Size of the array, n
            int n = Convert.ToInt32(tokens_in[0]);

            // Number of left rotations, k (representing the value of d)
            int k = Convert.ToInt32(tokens_in[1]);

            // The actual array of the integers
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int[] tempArray = new int[2 * n];

            // Constraints - also implementing new custom exceptions
            // which can enable some "production" ready code and also
            // if this were to be used for any sort of other reason
            // the code can terminate gracefully.
            if(n >= 100000 || n < 1)
            {
                throw new ArrayInputSizeException(string.Format("Cannot perform left rotations with the array size of: {0}", n));
                Environment.Exit(1); 
            }

            if(k > n || n < 1)
            {
                throw new LeftRotationQuantityException(string.Format("Cannot perform {0} left rotations on the array length of {1}", k, n));
                Environment.Exit(1); 
            }

            for(i = 0; i < n; i++)
            {
                if (a[i] > 1000000 || a[i] < 1)
                {
                    Environment.Exit(1); 
                }
            }

            // The actual logic
            for(j = 0; j < n; j++)
            {
                z = (j - k) % n;

                if (z != 0)
                {
                    z = (n + z) % n;
                }

                tempArray[z] = a[j];
            }

            // Viewing the updated array
            for(i = 0; i < n; i++)
            {
                Console.Write(tempArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}