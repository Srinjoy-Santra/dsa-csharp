namespace DSA.leetcode;

public class ValidSudoku
{
    public static bool Solution(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var squares =new Dictionary<(int,int), HashSet<char>>();

        for(int r=0;r<9;r++)
        for(int c=0;c<9;c++)
        {
            char element = board[r][c];
            if(element == '.')
                continue;
            rows.TryGetValue(r, out var row);
            cols.TryGetValue(c, out var col);
            squares.TryGetValue((r/3,c/3), out var square);
            
            if(
                (row != null && row.Contains(element))
                 || (col != null && col.Contains(element))
                 || (square != null && square.Contains(element))
                )
                return false;
            if (row == null)
                rows[r] = new();
            rows[r].Add(element);
            
            if (col == null)
                cols[c] = new();
            cols[c].Add(element);
            
            if (square == null)
                squares[(r/3,c/3)] = new(element);
            squares[(r/3,c/3)].Add(element);
        }
        return true;
    }
}

// Takeaways : 1. tryparse value does not return by reference. 2. HashSet cannot be set with initial value