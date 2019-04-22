namespace SumOfSubarrays
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            Console.WriteLine($"Sum of SubArrays: {SubArraySum(arr, n)}");
            Console.WriteLine("The program execution has completed. You can press any key to exit");
            Console.ReadKey();
        }

        public static long SubArraySum(int[] array, int n)
        {
            long result = 0;

            // Computing the sum of the subarrays with a formula
            for (int i = 0; i < n; i++)
            {
                result += array[i] * (i + 1) * (n - i);
            }

            return result;
        }
    }
}