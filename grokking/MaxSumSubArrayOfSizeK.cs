namespace dsa.grokking;

using System;
/*
 * Given an array of positive numbers and a positive number ‘k’,
 * find the maximum sum of any contiguous subarray of size ‘k’.
 */
public class MaxSumSubArrayOfSizeK
{

    public static int Solution(int[] arr, int k)
    {
        int start = 0, maxSum = 0, windowSum=0;
        for(int end=0;end<arr.Length;end++)
        {
            windowSum+=arr[end];

            if(end>=k-1)
            {
                maxSum = Math.Max(windowSum,maxSum);
                windowSum-=arr[start];
                start++;
            }
        }

        return maxSum;
    }

}

