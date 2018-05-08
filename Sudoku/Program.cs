using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] grid = new char[9][] { new char[]{'.', '.', '.', '1', '4', '.', '.', '2', '.' },
                                           new char[]{ '.', '.', '6', '.', '.', '.', '.', '.', '.' },
                                           new char[]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                                           new char[]{ '.', '.', '1', '.', '.', '.', '.', '.', '.'},
                                           new char[]{ '.', '6', '7', '.', '.', '.', '.', '.', '9' },
                                           new char[]{ '.', '.', '.', '.', '.', '.', '8', '1', '.'},
                                           new char[]{ '.', '3', '.', '.', '.', '.', '.', '.', '6' },
                                           new char[]{ '.', '.', '.', '.', '.', '7', '.', '.', '.'},
                                           new char[]{'.', '.', '.', '5', '.', '.', '.', '7', '.'}};

            Console.WriteLine("Original: ");

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    Console.Write(grid[i][j] + " "); 
                }

                Console.WriteLine(); 
            }

            bool result = Sudoku2(grid);

            Console.WriteLine("Final result: {0}", result);

            Console.ReadKey();
        }

        static bool Sudoku2(char[][] grid)
        {
            bool result; 

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] != '.' && !CheckSudoku(grid, i, j))
                    {
                        result = false;
                    }
                }
            }

            result = true;
            return result;
        }

        static bool CheckSudoku(char[][] grid, int x, int y)
        {
            bool output; 

            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[x][y] == grid[i][y] && x != i || 
                    grid[x][y] == grid[x][i] && y != i)
                {
                    output = false;
                }
            }

            int a = x / 3, b = y / 3;
            a *= 3;
            b *= 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[a+i][b+j] == grid[x][y] &&
                        (a+i != x && b+j != y))
                    {
                        output = false;
                    }
                }
            }

            output = true;
            return output;
        }
    }
}