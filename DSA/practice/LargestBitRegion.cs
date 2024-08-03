/*
---
problem: Given two binary strings a and b, return their sum as a binary string.
tags:
  - graph
  - dfs
  - medium
  - gfg
  - uipath
link: https://www.geeksforgeeks.org/find-length-largest-region-boolean-matrix/
---
*/

using System.Collections;

namespace DSA.practice;

public class LargestBitRegion
{
    public static void main()
    {
        int[,] matrix = new int[2,2]{{1,0},{1,1}};
        Console.WriteLine(LargestRegion(matrix));
        
        matrix = new int[2,2]{{1,1},{1,1}};
        Console.WriteLine(LargestRegion(matrix));
        
        matrix = new int[2,2]{{0,0},{1,1}};
        Console.WriteLine(LargestRegion(matrix));
        
        int[,] matrix2 = { { 0, 0, 1, 1, 0 },
            { 1, 0, 1, 1, 0 },
            { 0, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 1 } };
        Console.WriteLine(LargestRegion(matrix2));
        //BitArray bits = new BitArray(matrix.GetLength(0)* matrix.GetLength(1));
        
        
    }

    public static int LargestRegion(int[,] matrix)
    {
        int maxRegion = 0;
        for(int i=0;i<matrix.GetLength(0);i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            bool isZero = matrix[i,j] == 0;
            Dictionary<string, bool> visited = new();
            if (isZero)
                matrix[i,j] = 1;
            maxRegion = Math.Max(maxRegion, DFS(matrix, i , j, visited));
            if (isZero)
                matrix[i,j] = 0;
        }

        return maxRegion;
    }
    
    private static int DFS(int[,] matrix, int i, int j, Dictionary<string, bool> visited)
    {
        if (i < 0 || j < 0 || i >= matrix.GetLength(0) || j >= matrix.GetLength(1))
        {
            return 0;
        }
        //Console.WriteLine(i+","+j);
        string key = i + "," + j;
        if (visited.ContainsKey(key))
        {
            return 0;
        }
        visited[key] = true;
        return matrix[i, j]
            + DFS(matrix, i,j+1, visited) + DFS(matrix, i,j-1, visited) 
            + DFS(matrix, i+1,j, visited) + DFS(matrix, i-1,j, visited)
            + DFS(matrix, i-1,j, visited) + DFS(matrix, i-1,j, visited)
            + DFS(matrix, i+1,j + 1, visited) + DFS(matrix, i-1,j - 1, visited)
            ;
    }
}