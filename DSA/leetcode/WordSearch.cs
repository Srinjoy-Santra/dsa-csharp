using System.Collections;

namespace DSA.leetcode;

public class WordSearch
{
    private int _rows, _cols;
    private HashSet<(int, int)> _path = new();
    public bool Exist(char[][] board, string word) {
        _rows = board.Length;
        _cols = board[0].Length;
        for(int i=0;i<_rows;i++)
        for(int j=0;j<_cols;j++)
        {
            if(BackTrack(board, i,j, word, 0))
                return true;
        }
        return false;
    }

    private  bool BackTrack(char[][]board, int i, int j, string word, int k)
    {
        if(k == word.Length)
            return true;

        if(i<0||i>=_rows || j<0||j>=_cols || word[k] != board[i][j] || _path.Contains((i,j)))
            return false;

        _path.Add((i,j));
        
        // only vertical and horizontal search
        bool exists = BackTrack(board, i-1, j, word, k+1) 
                      || BackTrack(board, i, j-1, word, k+1) || BackTrack(board, i, j+1, word, k+1) 
                      || BackTrack(board, i+1, j, word, k+1);

        _path.Remove((i,j));
        return exists;
    }

    private void PrintVisited(BitArray visit, char[][]board, int m)
    {
        Console.WriteLine("Print visited");
        for (int i = 0; i < visit.Length; i++)
        {
            if(visit[i])
                Console.Write($"({i/m},{i%m}) = {board[i/m][i%m]} ->");
        }
    }

    public static void Run()
    {
        var board = new[]
        { 
            new[] {'A','B','C','E'},
            new[]  {'S','F','C','S'},
            new[]  {'A','D','E','E' }
        };
        string word = "ABBCCED";
        //Console.WriteLine(new WordSearch().Exist(board, word));

        board = new[] { new[] { 'a', 'b' }, new[] { 'c', 'd' } };
        word = "abcd";
       // Console.WriteLine(new WordSearch().Exist(board, word));
        
        
        board = new[] { new[] { 'A', 'B', 'C','E' }, new[] { 'S', 'F', 'E', 'S' }, new []{'A','D', 'E', 'E'} };
        word = "ABCESEEEFS";
        //Console.WriteLine(new WordSearch().Exist(board, word));

        board = new[]
        {
            new[]{ 'A', 'A', 'A', 'A', 'A', 'A' },
            new[]{ 'A', 'A', 'A', 'A', 'A', 'A' },
            new[]{ 'A', 'A', 'A', 'A', 'A', 'A' },
            new[]{ 'A', 'A', 'A', 'A', 'A', 'A' }, 
            new[]{ 'A', 'A', 'A', 'A', 'A', 'A' },
            new[]{ 'A', 'A', 'A', 'A', 'A', 'A' }
        };
        word = "AAAAAAAAAAAAAAB";
        Console.WriteLine(new WordSearch().Exist(board, word));


    }
}