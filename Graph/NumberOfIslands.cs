namespace Graph
{
    //200. Number of Islands
    //Given an m x n 2D binary grid grid which represents a map of '1's(land) and '0's(water), return the number of islands.

    //An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

    //Example 1:

    //Input: grid = [
    //  ["1","1","1","1","0"],
    //  ["1","1","0","1","0"],
    //  ["1","1","0","0","0"],
    //  ["0","0","0","0","0"]
    //]
    //Output: 1
    //Example 2:

    //Input: grid = [
    //  ["1","1","0","0","0"],
    //  ["1","1","0","0","0"],
    //  ["0","0","1","0","0"],
    //  ["0","0","0","1","1"]
    //]
    //Output: 3

    //Constraints:

    //m == grid.length
    //n == grid[i].length
    //1 <= m, n <= 300
    //grid[i][j] is '0' or '1'.
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }
            var islands = 0;

            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        GFS(grid, r, c);
                        islands++;
                    }
                }
            }
            return islands;
        }
        private void GFS(char[][] grid, int row, int column)
        {
            if (row < 0 || column < 0 || row >= grid.Length || column >= grid[0].Length || grid[row][column] == '0')
            {
                return;
            }
            grid[row][column] = '0';
            GFS(grid, row + 1, column);
            GFS(grid, row - 1, column);
            GFS(grid, row, column + 1);
            GFS(grid, row, column - 1);
        }
    }
}
