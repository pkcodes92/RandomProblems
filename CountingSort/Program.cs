/// <summary>
/// Write a C# program to sort a list of elements using the Counting sort
/// algorithm. In computer science, counting sort is an algorithm for sorting
/// a collection of objects according to keys that are small integers; that is, 
/// it is an integer sorting algorithm. It operates by counting the number of
/// objects that have each a distinct key value, and using arithmetic on those
/// counts to determine the positions of each key value in the output sequence. 
/// 
/// Its running time is linear in the number of items and the difference between
/// the maximum and minimum key values, so it is only suitable for direct use in
/// situations where the variation in keys is not significantly greater than the
/// number of items. However, it is oftent used a subroutine in another sorting
/// algorithm, radix sort, that can handle larger keys more efficiently.
/// </summary>

namespace CountingSort
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 };

            Console.WriteLine("\n" + "Original Array : ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            int[] sortedArray = new int[array.Length];

            // find the smallest and largest values
            int minVal = array[0];
            int maxVal = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                }
                else if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
        }
    }
}