public class Solution {
    public static bool IsAllRowsValid(char[][] board)
{
    for (int i = 0; i < 9; i++)
    {
        HashSet<char> ints = new HashSet<char>();
        for (int j = 0; j < 9; j++)
        {
            if (board[i][j] != '.' && !ints.Add(board[i][j]))
            {
                return false;
            }
        }
    }
    return true;
}

public static bool IsAllColsValid(char[][] board)
{
    for (int i = 0; i < 9; i++)
    {
        HashSet<char> ints = new HashSet<char>();
        for (int j = 0; j < 9; j++)
        {
            if (board[j][i] != '.' && !ints.Add(board[j][i]))
            {
                return false;
            }
        }
    }
    return true;
}

public static bool IsAll3x3Valid(char[][] board)
{
    for (int boxRow = 0; boxRow < 9; boxRow += 3)
    {
        for (int boxCol = 0; boxCol < 9; boxCol += 3)
        {
            HashSet<char> set = new HashSet<char>();

            for (int i = boxRow; i < boxRow + 3; i++)
            {
                for (int j = boxCol; j < boxCol + 3; j++)
                {
                    char current = board[i][j];

                    if (current == '.')
                        continue;

                    if (set.Contains(current))
                        return false;

                    set.Add(current);
                }
            }
        }
    }

    return true;
}
    public bool IsValidSudoku(char[][] board) {
        return (IsAllRowsValid(board) && IsAllColsValid(board) && IsAll3x3Valid(board));
    }
}
