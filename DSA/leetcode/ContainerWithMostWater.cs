// -*- coding: utf-8 -*-
// ---
// problem: Given an integer input array heights representing the heights of vertical lines, write a function that returns the maximum area of water that can be contained by two of the lines (and the x-axis). The function should take in an array of integers and return an integer.
// link: https://leetcode.com/problems/container-with-most-water/
// tags: 
//   - array
//   - two-pointers
// jupyter:
//   jupytext:
//     cell_metadata_filter: -all
//     formats: md,cs:light
//     text_representation:
//       extension: .cs
//       format_name: light
//       format_version: '1.5'
//       jupytext_version: 1.16.7
// ---

namespace DSA.leetcode;

public class ContainerWithMostWater
{
    public int MaxArea(int[] heights)
    {
        int left = 0, right = heights.Length-1, area=0;
        while(left < right)
        {
            // get minimum height among two
            int height = Math.Min(heights[left], heights[right]);
            // check area is more than the current max
            area = Math.Max(area, (right - left)*height);
            
            if(heights[left] > heights[right])
                right--;
            else left++;
        }
        return area;
    }
}
