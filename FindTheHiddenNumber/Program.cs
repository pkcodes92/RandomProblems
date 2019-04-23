namespace FindTheHiddenNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int n = a.Length;

            int hiddenNumber = FindHiddenNumber(a, n);

            Console.WriteLine($"The hidden number in the array: {hiddenNumber}");

            Console.ReadKey();
        }

        static int FindHiddenNumber(int[] a, int n)
        {
            long sum = 0; 
            for(int i = 0; i < n; i++)
            {
                sum += a[i];
            }

            // Dividing the sum by size of n
            long x = sum / n;

            // Print x, if found
            if (x * n == sum)
            {
                return (int)x; 
            }
            else
            {
                return -1; 
            }
        }
    }
}