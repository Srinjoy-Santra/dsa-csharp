

// ---
// problem: Given two binary strings a and b, return their sum as a binary string.
// tags:
// - bit-manipulation
// - easy
// - leetcode
// link: https://leetcode.com/problems/add-binary/
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
// +

using System.Text;

namespace DSA.leetcode;

public class ValidTriangleNumber
{
    public int BruteForce(int[] nums)
    {
        Array.Sort(nums);

        int count = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] > nums[k])
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    public int Solution(int[] nums)
    {
        Array.Sort(nums);
        
        int count = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            int left = 0, right = i-1;
            while(left < right)
            {
                if (nums[left] + nums[right] > nums[i])
                {
                    count += (right - left);
                    right--;
                }
                else left++;
            }
        }
        return count;
    }

    public static void Run()
    {
        int[] nums = [11, 4, 9, 6, 15, 18];
        ValidTriangleNumber validTriangleNumber = new();
        int result = validTriangleNumber.BruteForce(nums);
        Console.WriteLine(result);
        result = validTriangleNumber.Solution(nums);
        Console.WriteLine(result);
    }
}

