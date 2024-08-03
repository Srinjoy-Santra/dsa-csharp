using System.ComponentModel.DataAnnotations;

namespace DSA.leetcode;
/*
 * submission: https://leetcode.com/problems/longest-consecutive-sequence/submissions/935903672/
 * tags: [blind75]
 */
public class LongestConsecutiveSequence
{
    public static int Solution(int[] nums) // O(n)
    {
        var set = new HashSet<int>(nums); // O(n)
        int longest = 0;
        foreach (int num in nums) // O(n)
        {
            // does not have left neighbour
            if (!set.Contains(num - 1)) // O(1)
            {
                int length = 0;
                // have right neighbours?
                while (set.Contains(num + length)) // O(k); k < nll
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