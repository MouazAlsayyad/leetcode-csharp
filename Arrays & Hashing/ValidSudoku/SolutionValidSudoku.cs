namespace Arrays___Hashing.ValidSudoku
{
    public static class SolutionValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            int n = 9;

            // Check rows
            for (int i = 0; i < n; i++)
            {
                HashSet<char> rowSet = new HashSet<char>();
                for (int j = 0; j < n; j++)
                {
                    char ch = board[i][j];
                    if (ch != '.' && !rowSet.Add(ch))
                    {
                        return false;
                    }
                }
            }

            // Check columns
            for (int j = 0; j < n; j++)
            {
                HashSet<char> colSet = new HashSet<char>();
                for (int i = 0; i < n; i++)
                {
                    char ch = board[i][j];
                    if (ch != '.' && !colSet.Add(ch))
                    {
                        return false;
                    }
                }
            }

            // Check sub-boxes (3x3 grids)
            for (int i = 0; i < n; i += 3)
            {
                for (int j = 0; j < n; j += 3)
                {
                    HashSet<char> subBoxSet = new HashSet<char>();
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            char ch = board[i + k][j + l];
                            if (ch != '.' && !subBoxSet.Add(ch))
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
