namespace DSA.leetcode;

// https://leetcode.com/problems/maximum-subarray/
public class MaxSubArray
{
    public static int Solution(int[] nums) {
        if(nums.Length < 2) return nums[0];
        int maxSum = nums[0], curSum = 0;
        foreach(int num in nums)
        {
            if(curSum < 0)
                curSum = 0;
            curSum +=num;
            maxSum = Math.Max(maxSum, curSum);
        }
        return maxSum;
    }
    
    public static int Solution2(int[] nums) {
        int curSum = nums[0], maxSum = curSum;
        for(int i=1;i<nums.Length; i++)
        {
            curSum = Math.Max(curSum+nums[i], nums[i]);
            maxSum = Math.Max(maxSum, curSum);
        }
        return maxSum;
    }
}