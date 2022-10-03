namespace DSA.ctci;

// https://leetcode.com/problems/set-matrix-zeroes/

public class ZeroMatrix
{
    public static void Solution(int[,] matrix)
    {
        bool rowHasZero = false, colHasZero = false;

        // Check if first row has zero
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[0,j] == 0)
            {
                rowHasZero = true;
                break;
            }
        
        // Check if first column has zero
        for (int i = 0; i < matrix.GetLength(0); i++)
            if (matrix[i,0] == 0)
            {
                colHasZero = true;
                break;
            }
        
        
        // Check for zeros in the rst of the matrix and note it using the first column and row
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] == 0)
                {
                    matrix[i,0] = 0;
                    matrix[0,j] = 0;
                }
            }
        }
        

        //Nullify rows if first column has noted zero
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if(matrix[i,0]==0)
                matrix = NullifyRow(matrix, i);
        }
        
        //Nullify columns if first row has noted as zero
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if(matrix[0,j]==0)
                matrix = NullifyCol(matrix, j);
        }

        // Nullify first column / row if required
        if (rowHasZero) NullifyRow(matrix, 0);
        if (colHasZero) NullifyCol(matrix, 0);
    }

    private static int[,] NullifyRow(int[,] matrix, int row)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
            matrix[row, i] = 0;
        return matrix;
    }
    
    private static int[,] NullifyCol(int[,] matrix, int col)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            matrix[i, col] = 0;
        return matrix;
    }
    
    public static int[,] MySolution(int[,] arr)
    {
        List<int> rows = new(), cols = new();
        var narr = new int[arr.GetLength(0),arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                narr[i, j] = arr[i, j];
                if (arr[i,j] == 0)
                {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }
        

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (rows.Contains(i))
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                { 
                    narr[i,j] = 0;
                }
            }
        }
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (cols.Contains(j))
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                { 
                    narr[i,j] = 0;
                }
            }
        }

        return narr;
    }
}
