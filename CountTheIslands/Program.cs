namespace CountTheIslands
{
    using System;

    class Program
    {
        // Number of rows and columns
        static readonly int ROW = 5;
        static readonly int COL = 5; 

        /// <summary>
        /// A function to check if a given cell (row, col)
        /// can be included in the DFS (Depth-First-Search)
        /// </summary>
        /// <param name="map">The map for the islands to be counted</param>
        /// <param name="row">The row to look at</param>
        /// <param name="col">The column to look at</param>
        /// <param name="visited">The 2D array to see if an island was previously visited</param>
        /// <returns>A boolean variable marking a cell safe</returns>
        static bool IsSafe(int[,] map, int row, int col, bool[,] visited)
        {
            // Row number is in range,
            // Column number is in range,
            // and value is 1 and not yet visited
            return (row >= 0) && (row < ROW) &&
                   (col >= 0) && (col < COL) && (map[row, col] == 1 && !visited[row, col]);
        }

        /// <summary>
        /// A utility function to conduct the Depth-First-Search for a
        /// 2D boolean matrix. It only considers the 8 neighbors as
        /// adjacent vertices
        /// </summary>
        /// <param name="map">The map of the islands to be counted</param>
        /// <param name="row">The row to look at</param>
        /// <param name="col">The column to look at</param>
        /// <param name="visted">The 2D boolean array to see if an island was previously visited</param>
        static void DFS(int[,] map, int row, int col, bool[,] visited)
        {
            // These arrays are used to get row and column numbers
            // of 8 neighbors of a given cell
            int[] rowNbr = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colNbr = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

            // Mark this cell as visited
            visited[row, col] = true;

            // Recursively check for all connected neighbors
            for (int k = 0; k < 8; ++k)
            {
                if (IsSafe(map, row + rowNbr[k], col + colNbr[k], visited))
                {
                    DFS(map, row + rowNbr[k], col + colNbr[k], visited);
                }
            }
        }

        static int CountIslands(int[,] map)
        {
            // Make a boolean array to mark the visited cells. 
            // Initially all the cells are unvisited.
            bool[,] visited = new bool[ROW, COL];

            // Initialize the count to 0 and traverse
            // through all cells of the given map matrix
            int count = 0;

            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (map[i, j] == 1 &&
                        !visited[i, j])
                    {
                        // If a cell with a value of 1 is not visited yet, 
                        // then new island found. Visit all the cells in this
                        // island and increment the island count
                        DFS(map, i, j, visited);
                        ++count;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[,] map = new int[,]
            {
                {1, 1, 0, 0, 0},
                {0, 1, 0, 0, 1},
                {1, 0, 0, 1, 1},
                {0, 0, 0, 0, 0},
                {1, 0, 1, 0, 1}
            };

            Console.WriteLine($"Number of islands found: {CountIslands(map)}");

            Console.WriteLine("The program has finished execution, you may now press any key to exit");
            Console.ReadKey();
        }
    }
}