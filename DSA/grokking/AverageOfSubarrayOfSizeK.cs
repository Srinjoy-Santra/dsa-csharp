/*
---
Problem: Given an array, find the average of all contiguous subarrays of size ‘K’ in it.
Link: 
Tags: ['sliding-window', 'easy', 'grokking']
---
*/
namespace DSA.grokking;

public class AverageOfSubarrayOfSizeK
{
    public static double[] Solution(int size, int[] arr)
    {
        int sum = 0;
        var result = new double[arr.Length-size+1];
        // window is of fixed size 
        for (int end = 0; end < arr.Length; end++)
        {
            if (end >= size)
            {
                // end - size correctly points to results position
                result[end - size] = (double) sum / size;
                sum -= arr[end - size];
            }
            sum += arr[end]; 
        }
        result[^1] = (double) sum / size;
        return result;
    }
}