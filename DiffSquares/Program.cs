namespace DiffSquares
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][] { new int[] { 1, 2, 1 }, 
                                           new int[] { 2, 2, 2 }, 
                                           new int[] { 2, 2, 2 }, 
                                           new int[] { 1, 2, 3 }, 
                                           new int[] { 2, 2, 1 } };

            int diffSquaresCount = DifferentSquares(matrix);
            Console.WriteLine($"There are {diffSquaresCount} inside the provided matrix");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }

        static int DifferentSquares(int[][] matrix)
        {
            HashSet<string> s = new HashSet<string>();

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    s.Add(matrix[i][j].ToString() +
                          matrix[i + 1][j].ToString() +
                          matrix[i + 1][j + 1].ToString() +
                          matrix[i][j + 1].ToString());
                }
            }

            return s.Count;
        }
    }
}