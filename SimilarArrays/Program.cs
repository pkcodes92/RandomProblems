///<summary>
/// Two arrays are called <i>similar</i> if one can be obtained from another by swapping out at most
/// one pair of elements in one of the arrays. 
/// 
/// Given two arrays a and b, check whether they are similar.
///</summary>

using System;

namespace SimilarArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 1, 2, 3 };

            bool similar = AreSimilar(a, b);

            Console.WriteLine($"Are arrays A and B similar? {similar}");

            Console.ReadKey(); 
        }

        static bool AreSimilar(int[] a, int[] b)
        {
            int count = 0;
            int index = -1;
            bool sim = false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    if (count == 0)
                    {
                        index = i;
                    }
                    else if (count == 1)
                    {
                        if (a[i] == b[index] &&
                            b[i] == a[index])
                        {
                            sim = true;
                        }
                    }
                    else
                        return false;

                    count++; 
                }
            }

            if (sim || count == 0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}