/*
---
problem: Given an array of 0’s and 1’s, we need to write a program to find the minimum number of swaps required to group all 1’s present in the array together.
tags:
  - array
  - sliding-window
  - medium
  - gfg
  - uipath
link: https://www.geeksforgeeks.org/minimum-swaps-required-group-1s-together/
---
*/

namespace DSA.practice;

public class MinSwapsGroup1s
{
    public static void main()
    {
        int[] arr = { 1, 0, 1, 0, 1 };
        Console.WriteLine(MinSwaps(arr));
    }

    public static int MinSwaps(int[] arr)
    {
        int totalCountOfOnes = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                totalCountOfOnes++;
            }
        }

        int[] preCompute = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
                preCompute[0] = arr[i];
            }
            else
            {
                preCompute[i] = preCompute[i - 1] + arr[i];
            }
        }

        int maxCountOfOnes = 0;
        for (int i = totalCountOfOnes - 1; i < arr.Length; i++)
        {
            int countOfOnes = preCompute[i];
            if (i >= totalCountOfOnes)
                countOfOnes -= preCompute[i - totalCountOfOnes];

            maxCountOfOnes = Math.Max(maxCountOfOnes, countOfOnes);
        }

        return totalCountOfOnes - maxCountOfOnes;
    }
}