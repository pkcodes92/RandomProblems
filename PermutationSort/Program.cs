/// <summary>
/// Write a C# program to sort a list of elements using Permutation Sort.
/// 
/// Permutation sort, proceeds by generating the possible permutations of the input array/list until
/// discovering the sorted one.
/// 
/// Notes: 
/// * This actually employs the concept that is tied with method overloading
/// </summary>
namespace PermutationSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string str = "ABC";
            char[] arr = str.ToCharArray();
            GetPermutation(arr);

            Console.WriteLine("The program execution has completed, you may press any key to exit");
            Console.ReadKey();
        }

        static void GetPermutation(char[] list)
        {
            int x = list.Length - 1;
            GetPermutation(list, 0, x); 
        }

        static void GetPermutation(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.WriteLine(list);
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPermutation(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            // Below are exclusive-OR
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}