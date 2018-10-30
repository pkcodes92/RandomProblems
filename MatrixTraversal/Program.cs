using System;

namespace MatrixTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value for m: ");

            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a value for n: ");

            int n = int.Parse(Console.ReadLine());

            int numberOfPaths = CountPaths(m, n); 

            Console.WriteLine($"There are {numberOfPaths} for the {m} x {n} matrix");

            var isSquare = (m == n);

            Console.WriteLine($"Is the {m} x {n} matrix a square matrix? {isSquare}");

            Console.ReadKey(); 
        }

        static int CountPaths(int m, int n)
        {
            // Return 1 if it is the first row or first column
            if (m == 1 || n == 1)
            {
                return 1; 
            }

            // Recursively find the number of ways to reach the last cell.
            return CountPaths(m - 1, n) + CountPaths(m, n - 1);
        }
    }
}