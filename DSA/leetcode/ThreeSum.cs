// ---
// problem: Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
// link: https://leetcode.com/problems/3sum/
// tags: 
//   - array
//   - two-pointers
//
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


public class ThreeSum
{
    public static IList<IList<int>> Solution(int[] nums)
    {
        Array.Sort(nums);

        var result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            // skips duplicates
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1, right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum > 0) right--;
                else if (sum < 0) left++;
                else
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;

                    // it skips duplicate elements; faster 
                    while (nums[left] == nums[left - 1] && left < right)
                        left++;
                }
            }
        }

        return result;
    }
}
