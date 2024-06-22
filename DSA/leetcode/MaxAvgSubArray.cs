namespace DSA.leetcode;

public class MaxAvgSubArray
{
    public double FindMaxAverage2(int[] nums, int k) {

        if(k > nums.Length)
            return -1;

        int curSum = nums[0];

        for(int i=1;i<k;i++)
            curSum+=nums[i];

        int maxSum = curSum;

        for(int end=k;end<nums.Length;end++)
        {
            curSum = curSum + nums[end] - nums[end-k];
            maxSum=Math.Max(maxSum, curSum);
        }
        return maxSum / (double)k;
    }

    public double FindMaxAverage(int[] nums, int k) {
        int maxSum = nums[0];
        int curSum = nums[0];

        for(int end=1;end<nums.Length;end++)
        {
            curSum += nums[end];
            if(end == k -1)
            {
                maxSum = curSum;
            }
            if(end>=k)
            {
                curSum -= nums[end-k];
                maxSum=Math.Max(maxSum, curSum);
            }
        }
        return maxSum / (double)k;
    }
}