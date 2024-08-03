/*
---
problem: "Given an array of positive numbers and a positive number ‘S’,\rfind the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’. Return 0, if no such subarray exists."
tags:
  - sliding-window
  - easy
  - grokking
link: https://leetcode.com/problems/maximum-subarray/description/
---
 */
namespace DSA.grokking;

public class MinSizeSubArraySum
{

    public static int Solution(int[] arr, int S)
    {
       for(int size=1;size<S;size++)
       {
           int start=0,sum=0;
           for(int end=0;end<arr.Length;end++)
           {
               sum+=arr[end];
                if(end>=size-1)
                {
                    if(sum>=S)
                        return size;
                    start++;
                }
           }
       }

       return 0;
    }

    public static int Solution2(int[] arr, int S)
    {
        int start = 0, sum=0, minSize = int.MaxValue;
        for (int end = 0; end < arr.Length; end++)
        {
            sum += arr[end];
            while (sum >= S)
            {
                minSize = Math.Min(minSize, end-start+1);
                sum -= arr[start];
                start++;
            }
        }

        return minSize == int.MaxValue ? 0 : minSize;
    }
}

