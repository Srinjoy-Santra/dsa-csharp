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
                if(BackTrack(board, i,j, word, visit))
                    return true;
            }
        }
        return false;
    }

    private  bool BackTrack(char[][]board, int i, int j, string word, BitArray visit)
    {
        if(word.Length == 0)
            return true;

        int m = board.Length;
        int n = board[0].Length;
        if(i<0||i>=m || j<0||j>=n)
            return false;
        Console.WriteLine(i+","+ j);

        if(word[0] != board[i][j])
            return false;
        
        if(visit.Get(i*m+j))
            return false;

        visit.Set(i*m+j, true);
        
        string nw = word.Substring(1);
        Console.WriteLine(word[0]);

        
        // only vertical and horizontal search
        bool exists = BackTrack(board, i-1, j, nw, visit) 
                      || BackTrack(board, i, j-1, nw, visit) || BackTrack(board, i, j+1, nw, visit) 
                      || BackTrack(board, i+1, j, nw, visit);

        visit.Set(i*m+j, false);
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
        Console.WriteLine(new WordSearch().Exist(board, word));

    }
}