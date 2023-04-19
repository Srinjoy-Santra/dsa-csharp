using System.ComponentModel.DataAnnotations;

namespace DSA.leetcode;

// https://leetcode.com/problems/longest-consecutive-sequence/submissions/935903672/

public class LongestConsecutiveSequence
{
    public static int Solution(int[] nums)
    {
        var set = new HashSet<int>(nums);
        int longest = 0;
        foreach (int num in nums)
        {
            if (!set.Contains(num - 1))
            {
                int length = 0;
                while (set.Contains(num + length))
                {
                    length++;
                }

                if (length > longest)
                    longest = length;
            }
        }

        return longest;
    }
}