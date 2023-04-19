namespace DSA.leetcode;

// https://leetcode.com/problems/contains-duplicate/

public class ContainsDuplicate
{
    public bool Solution(int[] nums) {
        return new HashSet<int>(nums).Count != nums.Length;
    }
}