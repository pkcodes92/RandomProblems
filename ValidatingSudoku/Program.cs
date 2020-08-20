// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ValidatingSudoku
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This is the main driver class for the project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[][] grid = 
            {
                new int[] { 1, 3, 2, 5, 4, 6, 9, 8, 7 },
                new int[] { 4, 6, 5, 8, 7, 9, 3, 2, 1 },
                new int[] { 7, 9, 8, 2, 1, 3, 6, 5, 4 },
                new int[] { 9, 2, 1, 4, 3, 5, 8, 7, 6 },
                new int[] { 3, 5, 4, 7, 6, 8, 2, 1, 9 },
                new int[] { 6, 8, 7, 1, 9, 2, 5, 4, 3 },
                new int[] { 5, 7, 6, 9, 8, 1, 4, 3, 2 },
                new int[] { 2, 4, 3, 6, 5, 7, 1, 9, 8 },
                new int[] { 8, 1, 9, 3, 2, 4, 7, 6, 5 }
            };

            bool validPuzzle = ValidatePuzzle(grid); 
            Console.WriteLine($"Is the puzzle valid? {validPuzzle}");
            Console.ReadKey();
        }

        /// <summary>
        /// This method will actually validate the
        /// provided Sudoku puzzle
        /// </summary>
        /// <param name="grid">The 9 x 9 sudoku puzzle to validate</param>
        /// <returns>A final boolean value either true or false</returns>
        private static bool ValidatePuzzle(int[][] grid)
        {
            var horizontalLists = new List<List<int>>();
            var verticalLists = new List<List<int>>();
            var clustersLists = new List<List<int>>();

            for (var y = 0; y < 9; y++)
            {
                verticalLists.Add(grid[y].ToList());
            }

            for (var x = 0; x < 9; x++)
            {
                var horizontalList = new List<int>();
                for (var y = 0; y < 9; y++)
                {
                    horizontalList.Add(grid[y][x]);
                }

                horizontalLists.Add(horizontalList);
            }

            for (var x = 0; x < 9; x += 3)
            {
                for (var y = 0; y < 9; y += 3)
                {
                    var clustersList = new List<int>();
                    clustersList.Add(grid[y][x]);
                    clustersList.Add(grid[y + 1][x]);
                    clustersList.Add(grid[y + 2][x]);
                    clustersList.Add(grid[y][x + 1]);
                    clustersList.Add(grid[y + 1][x + 1]);
                    clustersList.Add(grid[y + 2][x + 1]);
                    clustersList.Add(grid[y][x + 2]);
                    clustersList.Add(grid[y + 1][x + 2]);
                    clustersList.Add(grid[y + 2][x + 2]);

                    clustersLists.Add(clustersList);
                }
            }

            bool horizontalRes = !horizontalLists.Any(horizontalList =>
                horizontalList.Any(i => horizontalList.Count(i1 => i1 == i) != 1));
            bool verticalRes =
                !verticalLists.Any(verticalList => verticalList.Any(i => verticalList.Count(i1 => i1 == i) != 1));
            bool clusterRes =
                !clustersLists.Any(clustersList => clustersList.Any(i => clustersList.Count(i1 => i1 == i) != 1));

            return horizontalRes && verticalRes && clusterRes;
        }
    }
}