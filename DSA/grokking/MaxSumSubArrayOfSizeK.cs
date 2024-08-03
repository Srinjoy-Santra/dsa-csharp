/*
---
Problem: Given an array of positive numbers and a positive number ‘k’, find the maximum sum of any contiguous subarray of size ‘k’.
Link:
Tags: ['sliding-window', 'easy', 'grokking']
Similar: https://leetcode.com/problems/maximum-subarray/description/
--- 
*/

namespace DSA.grokking;

using System;

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

    public static int Solution2(int[] arr, int k)
    {
        int maxSum = 0, sum=0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i >= k)
            {
                maxSum = Math.Max(sum, maxSum);
                sum -= arr[i - k];
            }
            sum += arr[i];
        }

        return maxSum;
    }
}

