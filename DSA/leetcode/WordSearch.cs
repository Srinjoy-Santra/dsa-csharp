using System.Collections;

namespace DSA.leetcode;

public class WordSearch
{
    public bool Exist(char[][] board, string word) {
        int k=0;
        int m = board.Length;
        int n = board[0].Length;
        BitArray visit = new(m * n);
        for(int i=0;i<m;i++)
        for(int j=0;j<n;j++)
        {
            if(board[i][j] == word[k])
            {
                if(BackTrack(board, i,j, word, visit, k))
                    return true;
            }
        }
        return false;
    }

    private  bool BackTrack(char[][]board, int i, int j, string word, BitArray visit, int k)
    {
        if(k == word.Length)
            return true;

        int m = board.Length;
        int n = board[0].Length;
        if(i<0||i>=m || j<0||j>=n)
            return false;
        Console.WriteLine(i+","+ j);

        if(word[k] != board[i][j])
            return false;
        
        if(visit.Get(i*n+j))
            return false;

        visit.Set(i*n+j, true);
        
        // only vertical and horizontal search
        bool exists = BackTrack(board, i-1, j, word, visit, k+1) 
                      || BackTrack(board, i, j-1, word, visit, k+1) || BackTrack(board, i, j+1, word, visit, k+1) 
                      || BackTrack(board, i+1, j, word, visit, k+1);

        visit.Set(i*n+j, false);
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